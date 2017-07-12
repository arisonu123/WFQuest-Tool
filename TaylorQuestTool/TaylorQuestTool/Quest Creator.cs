/*Alison Taylor
 * /04/13/15
 * Quest Creator- Lets user enter quest information and save the information into a text file
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaylorQuestTool
{
    public partial class questCreator : Form
    {
        private questData quest;
       
        public questCreator()
        {
            InitializeComponent();
            quest = new questData();
            ResetQuest();
            stepsList.DataSource = quest.questSteps;
            stepsList.AllowDrop = true;


             this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;       

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            questDataBindingSource.DataSource = quest;
        }


        private void ResetQuest()
        {
            quest._questName = "";
            quest._questLevel = 0;
            quest._experienceReward = 0;
            quest._cashReward = 0;
            quest._isThisQuestTimed = false;
            quest.questTimer = 0;
            quest.questDescription = "";
            quest.questDifficulty = null;
            quest._numItemsRewarded = 0;
            quest.questSteps.Clear();
            quest._currentStepDescription = "";
            quest._currentStepCompletesQuest=false;
            quest._currentStepType = "";
            quest._currentStepKillCount = 0;
            quest.clearLists();
            quest.resetIncrementers();
        }





        //functions to get data from UI
   

        private void isQuestTimed_CheckedChanged(object sender, EventArgs e)
        {
            bool isThisQuestTimed = (sender as CheckBox).Checked;
            if (isThisQuestTimed == true)//make the questTimeNumber NumericUpDown editable if quest is timed, otherwise make it not editable
            {
                questTimeNumber.ReadOnly = false;
            }
            else
            {
                questTimeNumber.ReadOnly = true;
            }
        }


        private void saveButton_Click(object sender, EventArgs e)//save file when save button is clicked
        {
            List<string> itemsRewarded = new List<string>();
            //quest.saveQuest();
            quest.questNumber += 1;
            string fileName = "QU_" + quest.questNumber + "data" + ".txt";//get quest id

            for (int i = 1; i <= quest._numItemsRewarded; i++)//add items to item list
            {
                itemsRewarded.Add("IT_" + i);
            }

            //put data in file
            System.IO.TextWriter tw = new System.IO.StreamWriter(fileName);
            tw.WriteLine("Quest ID : QU_" + quest.questNumber);
            tw.WriteLine("Quest Name : " + quest._questName);
            tw.WriteLine("Quest Level : " + quest._questLevel);
            tw.WriteLine("Experience Reward : " + quest._experienceReward);
            tw.WriteLine("Cash Reward : " + quest._cashReward);
            tw.WriteLine("Quest Difficulty : " + quest.questDifficulty);
            tw.WriteLine("Is Quest Timed : " + quest._isThisQuestTimed);
            if (quest._isThisQuestTimed == true)
            {
                tw.WriteLine("Timer : " + quest.questTimer);
            }
            string itemData = "";
            for (int i = 0; i < itemsRewarded.Count; i++)//add items to data string
            {
                if (i == itemsRewarded.Count - 1)
                {
                    itemData = itemData + itemsRewarded[i];
                    tw.WriteLine(itemData);
                }
                else if (i == 0)
                {
                    itemData = "Items Rewarded : " + itemsRewarded[i] + " , ";
                }
                else
                {
                    itemData = itemData + itemsRewarded[i] + " , ";
                }
            }
            tw.WriteLine("Quest Description : " + quest.questDescription);
            tw.WriteLine("Steps: ");


            int[] stepGoalIndex = new int[quest._stepsGoal.Count];
            string[] stepGoalValue = new string[quest._stepsGoal.Count];
            System.Collections.ICollection keyCollection = quest._stepsGoal.Keys;
            keyCollection.CopyTo(stepGoalIndex, 0);
            System.Collections.ICollection valueCollection = quest._stepsGoal.Values;
            valueCollection.CopyTo(stepGoalValue, 0);
            string stepNum = "";
            int stepIndex = 0;
            for (int j = 0; j < quest.questSteps.Count; j++)
            {
                tw.WriteLine("Step ID : " + quest.questSteps[j]);
                //get index that this step id corresponds to in the step data lists
                stepNum = quest.questSteps[j].Substring(quest.questSteps[j].IndexOf("_") + 1);
                stepIndex = int.Parse(stepNum);
                stepIndex -= 1;
                tw.WriteLine("Step Description : " + quest._stepsDescription[stepIndex]);
                tw.WriteLine("Does step complete quest : " + quest._isCompletionStep[stepIndex]);


                tw.WriteLine("Step Type : " + quest._stepsType[stepIndex]);
                string stepGoalIndexValue = stepGoalValue[stepIndex];
                if (quest._stepsType[stepIndex] == "Kill")
                {
                    tw.WriteLine("Kill Number : " + stepGoalIndexValue);
                }
                else if (quest._stepsType[stepIndex] == "Explore")
                {
                    tw.WriteLine("Location ID : " + stepGoalIndexValue);
                }
                else
                {
                    tw.WriteLine("Conversation ID : " + stepGoalIndexValue);
                }
            }
            itemsRewarded.Clear();
            tw.Close();
        }

        private void stepSaveButton_Click(object sender, EventArgs e)
        {
            quest.addStep();
        }

        private void stepTypeSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

            string stepTypeChosen = (string)(sender as ComboBox).SelectedItem;
            if (stepTypeChosen == "Kill")//make the killNumber NumericUpDown editable if the stepType is Kill, otherwise make it not editable
            {
                killNumber.ReadOnly = false;
            }
            else
            {
                killNumber.ReadOnly = true;
            }
        }

        private void stepsList_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.stepsList.SelectedItem == null) return;
            this.stepsList.DoDragDrop(this.stepsList.SelectedItem, DragDropEffects.Move);
        }

        private void stepsList_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void stepsList_DragDrop(object sender, DragEventArgs e)
        {
            Point point = stepsList.PointToClient(new Point(e.X, e.Y));
            int index = this.stepsList.IndexFromPoint(point);
            if (index < 0) index = this.stepsList.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            quest.questSteps.Remove(data.ToString());
            quest.questSteps.Insert(index, data.ToString());
        }
        
        private void difficultySettings_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {

            if (difficultySettings.SelectedIndex==-1&&difficultySettings.Text!="Select Difficulty")
            {
                // set the text back to a valid settting
      
                difficultySettings.Select(0, difficultySettings.Text.Length);

            }
        }

        private void stepTypeSettings_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {

            if (stepTypeSettings.SelectedIndex == -1&&difficultySettings.Text!="Select Step Type")
            {
                // set the text back to a valid settting

                stepTypeSettings.Select(0, difficultySettings.Text.Length);

            }
        }


    }
}
