using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using System.Collections.ObjectModel;
namespace CarrierCommand2SaveEditor
{
    public partial class SaveEditor : Form
    {
        string XmlBaseLine = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
        string XmlBaseLineNl = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n";
        string MetaLine = "<meta save_version=\"1\"/>\n";
        public SaveEditor()
        {
            InitializeComponent();
        }

        /* File Handling */

        void OpenBtn_MouseClick(object sender, EventArgs e)
        {
            OpenSaveFile();
        }

        void SaveBtn_MouseClick(object sender, EventArgs e) { SaveSaveFile(); }

        private OpenFileDialog openFileDialog1;
        void OpenSaveFile()
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ParseXmlSaveFile();
                    FindTeams();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private SaveFileDialog saveFileDialog1;
        void SaveSaveFile()
        {
            saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string master = XmlBaseLineNl + MetaLine;

                StringWriter sw;
                XmlTextWriter xw;

                sw = new StringWriter();
                xw = new XmlTextWriter(sw);
                xw.Formatting = Formatting.Indented;

                xmlScene.WriteTo(xw);
                master += sw.ToString();

                sw = new StringWriter();
                xw = new XmlTextWriter(sw);
                xw.Formatting = Formatting.Indented;

                xmlVehicle.WriteTo(xw);
                master += sw.ToString();

                sw = new StringWriter();
                xw = new XmlTextWriter(sw);
                xw.Formatting = Formatting.Indented;

                xmlMissile.WriteTo(xw);
                master += sw.ToString();

                Console.WriteLine(saveFileDialog1.FileName);

                File.WriteAllText(saveFileDialog1.FileName, master);
            }



        }

        public XmlDocument xmlScene;
        public XmlDocument xmlVehicle;
        public XmlDocument xmlMissile;        

        void ParseXmlSaveFile()
        {
            string fileLocation = openFileDialog1.FileName;

            string file = File.ReadAllText(fileLocation);

            /*
             * 
             * 
             * 
             */

            int startIndex, endIndex;
            startIndex = endIndex = 0;

            startIndex = file.IndexOf("<scene");
            endIndex = file.IndexOf("</scene>");
            string docScene = file.Substring(startIndex, endIndex - (startIndex - 8));
            string docSceneRooted = XmlBaseLineNl + docScene;

            startIndex = file.IndexOf("<vehicles>", file.IndexOf("</scene>"));
            endIndex = file.IndexOf("</vehicles>", file.IndexOf("</vehicles>", file.IndexOf("</scene>")) + 1);
            string docVehicle = file.Substring(startIndex, endIndex - (startIndex - 11));
            string docVehicleRooted = XmlBaseLineNl + docVehicle;


            if (file.IndexOf("<missiles/>") == -1)
            {
                startIndex = file.IndexOf("<missiles>");
                endIndex = file.IndexOf("</missiles>", file.IndexOf("</missiles>") + 1);
            }
            else 
            {
                startIndex = file.IndexOf("<missiles>");
                endIndex = file.IndexOf("</missiles>");
            }
            
            string docMissile = file.Substring(startIndex, endIndex - (startIndex - 11));
            string docMissileRooted = XmlBaseLineNl + docMissile;

            /*
             * 
             * 
             * 
             */

            xmlScene = new XmlDocument();
            xmlScene.LoadXml(XDocument.Parse(docScene).ToString());

            xmlVehicle = new XmlDocument();
            xmlVehicle.LoadXml(XDocument.Parse(docVehicle).ToString());

            xmlMissile = new XmlDocument();
            xmlMissile.LoadXml(XDocument.Parse(docMissile).ToString());

            /*
             * 
             * 
             * 
             */

            /* Send to Node Editor */

            primaryTreeView.Nodes.Clear();
            AddRootNode(xmlScene, primaryTreeView);
            AddRootNode(xmlVehicle, primaryTreeView);
            AddRootNode(xmlMissile, primaryTreeView);
        }

        /* Xml Node Editor */

        void PrimaryTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            secondaryTreeView.Nodes.Clear();

            primaryListView.Items.Clear();
            primaryListView.Tag = ((XmlNode)e.Node.Tag);

            RefreshListNode(primaryListView);
        }

        void SecondaryTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            secondaryListView.Items.Clear();
            secondaryListView.Tag = ((XmlNode)e.Node.Tag);

            RefreshListNode(secondaryListView);
        }

        void PrimaryValue_TextChange(object sender, EventArgs e)
        {
            ((XmlAttribute)primaryTbValue.Tag).OwnerElement.SetAttribute(((XmlAttribute)primaryTbValue.Tag).Name, primaryTbValue.Text);
            RefreshListNode(primaryListView);
        }

        void SecondaryValue_TextChange(object sender, EventArgs e)
        {
            ((XmlAttribute)secondaryTbValue.Tag).OwnerElement.SetAttribute(((XmlAttribute)secondaryTbValue.Tag).Name, secondaryTbValue.Text);
            RefreshListNode(secondaryListView);
            UpdateStateXML();
        }

        void PrimaryList_MouseClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem i = primaryListView.SelectedItems[0];

                primaryTbName.Tag = (XmlAttribute)i.Tag;
                primaryTbValue.Tag = (XmlAttribute)i.Tag;

                primaryTbName.Text = ((XmlAttribute)i.Tag).Name;
                primaryTbValue.Text = ((XmlAttribute)i.Tag).Value;
            }
            catch (ArgumentOutOfRangeException err)
            {

            }
        }

        void SecondaryList_MouseClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem i = secondaryListView.SelectedItems[0];

                secondaryTbName.Tag = (XmlAttribute)i.Tag;
                secondaryTbValue.Tag = (XmlAttribute)i.Tag;

                secondaryTbName.Text = ((XmlAttribute)i.Tag).Name;
                secondaryTbValue.Text = ((XmlAttribute)i.Tag).Value;
            }
            catch (ArgumentOutOfRangeException err)
            {

            }
        } 
        
        void AddRootNode(XmlDocument xmlDocument, TreeView treeView)
        {
            treeView.BeginUpdate();
            int nodeIndex = treeView.Nodes.Add(new TreeNode(xmlDocument.DocumentElement.Name));
            XmlNode xmlParentNode = xmlDocument.ChildNodes[0];
            TreeNode treeParentNode = treeView.Nodes[nodeIndex];

            Console.WriteLine(xmlParentNode.Name.ToString());

            treeParentNode.Tag = xmlParentNode;

            AddNodes(xmlParentNode, treeParentNode);
            treeView.EndUpdate();
        }

        void AddNodes(XmlNode xmlParentNode, TreeNode treeParentNode)
        {
            TreeNode tNode;
            XmlNode xNode;
            XmlNodeList nodeList;
            treeParentNode.Tag = xmlParentNode;
            treeParentNode.Text = xmlParentNode.Name.ToString();
            if (xmlParentNode.HasChildNodes)
            {
                nodeList = xmlParentNode.ChildNodes;

                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = xmlParentNode.ChildNodes[i];
                    treeParentNode.Nodes.Add(new TreeNode(xNode.Name));


                    tNode = treeParentNode.Nodes[i];
                    AddNodes(xNode, tNode);

                }
            }
            else
            {

            }
        }
       
        void HandleStateXml(XmlAttribute attribute)
        {
            secondaryTreeView.Nodes.Clear();
            string xmlString = attribute.Value;
            //xmlString = xmlString.Replace("&gt;", ">");
            //xmlString = xmlString.Replace("&lt;", "<");

            Console.WriteLine(xmlString);

            XmlDocument xmlState = new XmlDocument();
            xmlState.LoadXml(xmlString);

            secondaryTreeView.Tag = new StateXmlObject(attribute, xmlState);
            AddNodes(xmlState.ChildNodes[1], secondaryTreeView.Nodes.Add(xmlState.ChildNodes[1].Name));

        }

        void UpdateStateXML()
        {
            foreach (XmlAttribute attr in ((XmlNode)primaryListView.Tag).Attributes)
            {
                if (attr.Name == "state")
                {
                    StringWriter sw = new StringWriter();
                    XmlTextWriter xw = new XmlTextWriter(sw);
                    xw.Formatting = Formatting.Indented;
                    ((StateXmlObject)secondaryTreeView.Tag).document.WriteTo(xw);
                    ((StateXmlObject)secondaryTreeView.Tag).parent.Value = sw.ToString();

                    Console.WriteLine(((StateXmlObject)secondaryTreeView.Tag).parent.Value);
                }
            }
        }
        
        void RefreshListNode(ListView listView)
        {
            listView.Items.Clear();
            foreach (XmlAttribute attr in ((XmlNode)listView.Tag).Attributes)
            {
                ListViewItem item = listView.Items.Add(attr.Name + " : " + attr.Value);
                item.Tag = attr;


                if (attr.Name == "state" && listView == primaryListView)
                {
                    HandleStateXml(attr);
                }
                else if (attr.Name == "state" && listView == secondaryListView)
                {
                    Console.WriteLine("Notices a 3rd Level XML State");
                }
            }
        }

        /* Custom Setting Editor */

        void FindTeams() 
        {
            listView3.Clear();
            listView3.BeginUpdate();
            foreach (XmlElement teamElement in xmlScene["scene"]["teams"]["teams"]) 
            {
                XmlElement teamNode = null;
                XmlElement carrierNode = null;
                string carrierId = "";
                XmlElement carrierStateNode = null;
                string teamId = teamElement.GetAttribute("id").ToString();

                Console.WriteLine("Team Find");

                if (teamId != "0")
                {
                    teamNode = teamElement;
                    foreach (XmlElement element in xmlVehicle["vehicles"]["vehicles"])
                    {
                        if (element.GetAttribute("definition_index") == "0" && element.GetAttribute("team_id") == teamId)
                        {

                            Console.WriteLine("Carrier Find");

                            carrierNode = element;
                            carrierId = element.GetAttribute("id");
                        }
                    }
                    foreach (XmlElement element in xmlVehicle["vehicles"]["vehicle_states"])
                    {
                        if (element.GetAttribute("id") == carrierId)
                        {

                            Console.WriteLine("State Find");

                            carrierStateNode = element;
                        }
                    }
                    if (teamNode != null && carrierNode != null && carrierStateNode != null)
                    {
                        TeamSaveObject saveObject = new TeamSaveObject(teamNode, carrierNode, carrierStateNode);
                        ListViewItem item = listView3.Items.Add(teamId);
                        item.Tag = saveObject;

                    }
                    else 
                    {
                        Console.WriteLine("Nulled Team");
                    }
                }
                
            }
            listView3.EndUpdate();
        }

        void TeamList_MouseClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem i = listView3.SelectedItems[0];
                UpdateTeamViews((TeamSaveObject)i.Tag);

            }
            catch (ArgumentOutOfRangeException err)
            {
                Console.WriteLine("Event Error");
            }
        }

        void UpdateTeamViews(TeamSaveObject teamSave)
        {
            if (teamSave == null) 
            {
                Console.WriteLine("Null Team");
                return;
            }
            Console.WriteLine(teamSave.RootCarrierVehicleStateNode.Name);
            string xmlString = teamSave.RootCarrierVehicleStateNode.GetAttribute("state");

            listView4.Items.Clear();
            listView1.Items.Clear();

            XmlDocument xmlState = new XmlDocument();
            xmlState.LoadXml(xmlString);

            listView4.Tag = new StateXmlObject(teamSave.RootCarrierVehicleStateNode.GetAttributeNode("state"), xmlState);



            int itemIndex = 0;
            foreach (XmlElement element in ((StateXmlObject)listView4.Tag).document["data"]["inventory"]["item_quantities"]) 
            {
                ListViewItem item = new ListViewItem(ItemIDs.ITEMS[itemIndex]);
                item.SubItems.Add(element.GetAttribute("value"));
                item.Tag = element.GetAttributeNode("value");
                listView4.Items.Add(item);
                
                Console.WriteLine(element.GetAttribute("value"));
                itemIndex++;
            }




            listView1.Tag = teamSave.RootTeamNode["unlocked_blueprints"];

            ////xmlString = xmlString.Replace("&gt;", ">");
            ////xmlString = xmlString.Replace("&lt;", "<");

            //Console.WriteLine(xmlString);



            //secondaryTreeView.Tag = new StateXmlObject(attribute, xmlState);
            //AddNodes(xmlState.ChildNodes[1], secondaryTreeView.Nodes.Add(xmlState.ChildNodes[1].Name));

        }

        void InventoryList_MouseClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem i = listView4.SelectedItems[0];

                textBox5.Tag = (XmlAttribute)i.Tag;
                textBox5.Text = ((XmlAttribute)i.Tag).Value;
            }
            catch (ArgumentOutOfRangeException err)
            {

            }
        }

        void InventoryValue_TextChange(object sender, EventArgs e)
        {
            ((XmlAttribute)textBox5.Tag).Value = textBox5.Text;
            RefreshInventoryList(listView4);
            UpdateStateInventoryXML();
        }

        void RefreshInventoryList(ListView listView)
        {
            listView.Items.Clear();
            int itemIndex = 0;
            foreach (XmlElement element in ((StateXmlObject)listView.Tag).document["data"]["inventory"]["item_quantities"])
            {
                ListViewItem item = new ListViewItem(ItemIDs.ITEMS[itemIndex]);
                item.SubItems.Add(element.GetAttribute("value"));
                item.Tag = element.GetAttributeNode("value");
                listView4.Items.Add(item);

                Console.WriteLine(element.GetAttribute("value"));
                itemIndex++;
            }
        }

        void UpdateStateInventoryXML() 
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);
            xw.Formatting = Formatting.Indented;
            ((StateXmlObject)listView4.Tag).document.WriteTo(xw);
            ((StateXmlObject)listView4.Tag).parent.Value = sw.ToString();

            Console.WriteLine(((StateXmlObject)listView4.Tag).parent.Value);
            //foreach (XmlAttribute attr in ((XmlNode)primaryListView.Tag).Attributes)
            //{
            //    if (attr.Name == "state")
            //    {
            //        StringWriter sw = new StringWriter();
            //        XmlTextWriter xw = new XmlTextWriter(sw);
            //        xw.Formatting = Formatting.Indented;
            //        ((StateXmlObject)secondaryTreeView.Tag).document.WriteTo(xw);
            //        ((StateXmlObject)secondaryTreeView.Tag).parent.Value = sw.ToString();

            //        Console.WriteLine(((StateXmlObject)secondaryTreeView.Tag).parent.Value);
            //    }
            //}
        }

    }

    public class StateXmlObject
    {
        public XmlAttribute parent;
        public XmlDocument document;

        public StateXmlObject(XmlAttribute parent, XmlDocument document)
        {
            this.parent = parent;
            this.document = document;
        }
    }

    public class TeamSaveObject
    {
        public XmlElement RootTeamNode;
        public XmlElement RootCarrierVehicleNode;
        public XmlElement RootCarrierVehicleStateNode;

        public TeamSaveObject(XmlElement rTN, XmlElement rCVN, XmlElement rCVSN) 
        {
            RootTeamNode = rTN;
            RootCarrierVehicleNode = rCVN;
            RootCarrierVehicleStateNode = rCVSN;
        }
    }

    public class ItemIDs 
    {
        public static string[] ITEMS = new string[51]
        {
            "Ammo 30mm", 
            "Seal Chassis", 
            "Walrus Chassis", 
            "Bear Chassis", 
            "Albatros Chassis", 
            "Manta Chassis", 
            "Razorbill Chassis", 
            "Petrel Chassis", 
            "???", 
            "Turret 30mm", 
            "Aircraft Chaingun",
            "Rocket Pod",
            "Turret (CIWS)",
            "Turret (IR Missile)",
            "Bomb (Light)",
            "Bomb (Medium)",
            "Bomb (Heavy)",
            "Missile (IR)",
            "Missile (Laser)",
            "Missile (AA)",
            "Actuated Camera",
            "???",
            "Gimbal Camera",
            "Observation Camera",
            "Radar (AWACS)",
            "Fuel Tank (Aircraft)",
            "Flare Launcher",
            "Battle Cannon",
            "Artillery Gun",
            "Cruise Missile",
            "Rocket",
            "Ammo (Flare)",
            "Ammo (20mm)",
            "Ammo (100mm)",
            "Ammo (120mm)",
            "Ammo (160mm)",
            "Fuel (1000L)",
            "Torpedo",
            "Tv-Guided Missile",
            "Torpedo (Noise)",
            "Torpedo (Countermeasure)",
            "Radar",
            "Sonic Pulse Generator",
            "Smoke Launcher (Stream)",
            "Smoke Launcher (Explosive)",
            "Ammo (Sonic Pulse)",
            "Ammo (Smoke)",
            "Turret 40mm",
            "Ammo (40mm)",
            "Heavy Cannon",
            "Virus Module"
        };
    }
}
