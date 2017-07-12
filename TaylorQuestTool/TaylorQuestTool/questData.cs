using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace TaylorQuestTool
{
    public class questData: System.ComponentModel.INotifyPropertyChanged
    {
        //current quest data
        private string questName;
        private int questLevel;
        private int experienceReward;
        private int cashReward;
        private string difficulty;
        private bool isThisQuestTimed;
        private double time;
        private int numItemsRewarded;
        private string description;
  //      private List<string> itemsRewarded = new List<string>();

        //current step data
        private string currentStepDescription;
        private bool currentStepCompletesQuest;
        private string currentStepType;
        private int currentStepKillCount;


        //incrementers
        public int questNumber { get; set; }
        public int stepNumber { get; set; }
        public int locNumber  { get; set; }
        public int convoNumber { get; set; }

        //current quest step data
        private BindingList<string> steps=new BindingList<string>();
        private List<string> stepsDescription=new List<string>();
        private List<bool> stepsCompletesQuest=new List<bool>();
        private List<string> stepsType = new List<string>();
        private OrderedDictionary stepsGoal=new OrderedDictionary();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the list of all steps types
        /// </summary>
        public List<string> _stepsType{
            get { return stepsType; }

         } 

        /// <summary>
        /// gets the ordered dictionary of steps goal with thier step id as the key
        /// </summary>
        public OrderedDictionary _stepsGoal
        {

            get { return stepsGoal; }
        }

        /// <summary>
        /// gets/set questName
        /// </summary>
        public string _questName
        {
            get { return questName; }
            set
            {
                if (value != questName)
                {
                    questName= value;
                    NotifyPropertyChanged("_questName");
                }
            }
        }

        /// <summary>
        /// get/set questLevel
        /// </summary>
        public int _questLevel
        {
            get { return questLevel; }
            set
            {
                if (value != questLevel)
                {
                    questLevel = value;
                    NotifyPropertyChanged("_questLevel");
                }
            }
        }

        /// <summary>
        /// Get/set experience reward
        /// </summary>
        public int _experienceReward
        {
            get { return experienceReward; }
            set
            {
                if (value != experienceReward)
                {
                    experienceReward = value;
                    NotifyPropertyChanged("_experienceReward");
                }
            }
        }

        /// <summary>
        /// Get/set cash reward
        /// </summary>
        public int _cashReward
        {
            get { return cashReward; }
            set
            {
                if (value != cashReward)
                {
                    cashReward = value;
                    NotifyPropertyChanged("_cashReward");
                }
            }
        }

        /// <summary>
        /// gets/set difficulty
        /// </summary>
        public string questDifficulty
        {
            get { return difficulty; }
            set
            {
                if (value != difficulty)
                {
                    difficulty = value;
                    NotifyPropertyChanged("questDifficulty");
                }
            }
        }

      
        /// <summary>
        /// gets/set time
        /// </summary>
        public double questTimer
        {
            get { return time; }
            set
            {
                if (value != time)
                {
                    time = value;
                    NotifyPropertyChanged("questTimer");
                }
            }
        }

        /// <summary>
        /// gets/set isThisQuestTime
        /// </summary>
        public bool _isThisQuestTimed
        {
            get { return isThisQuestTimed; }
            set
            {
                if (value != isThisQuestTimed)
                {
                    isThisQuestTimed = value;
                    NotifyPropertyChanged("_isThisQuestTimed");
                }
            }
        }

        /// <summary>
        /// gets/set numItemsRewarded
        /// </summary>
        public int _numItemsRewarded
        {
            get { return numItemsRewarded; }
            set
            {
                if (value != numItemsRewarded)
                {
                    numItemsRewarded = value;
                    NotifyPropertyChanged("_numItemsRewarded");
                }
            }
        }


        /// <summary>
        /// gets/set description
        /// </summary>
        public string questDescription
        {
            get { return description; }
            set
            {
                if (value != description)
                {
                    description = value;
                    NotifyPropertyChanged("questDescription");
                }
            }
        }

        /// <summary>
        /// gets/set steps
        /// </summary>
        public BindingList<string> questSteps
        {
            get { return steps; }
            set
            {
                if (value != steps)
                {
                    steps = value;
                    NotifyPropertyChanged("questSteps");
                }
            }
        }

        /// <summary>
        /// gets/set currentStepDescription
        /// </summary>
        public string _currentStepDescription
        {
            get { return currentStepDescription; }
            set
            {
                if (value != currentStepDescription)
                {
                    currentStepDescription= value;
                    NotifyPropertyChanged("_currentStepDescription");
                }
            }
        }

        /// <summary>
        /// gets/set currentStepCompletesQuest
        /// </summary>
        public bool _currentStepCompletesQuest
        {
            get { return currentStepCompletesQuest; }
            set
            {
                if (value != currentStepCompletesQuest)
                {
                    currentStepCompletesQuest = value;
                    NotifyPropertyChanged("_currentStepCompletesQuest");
                }
            }
        }

        /// <summary>
        /// gets/set currentStepType
        /// </summary>
        public string _currentStepType
        {
            get { return currentStepType; }
            set
            {
                if (value != currentStepType)
                {
                    currentStepType=value;
                    NotifyPropertyChanged("_currentStepType");
                }
            }
        }

        /// <summary>
        /// gets/set currentStepKillCount
        /// </summary>
        public int _currentStepKillCount
        {
            get { return currentStepKillCount; }
            set
            {
                if(value != currentStepKillCount)
                {
                    currentStepKillCount = value;
                    NotifyPropertyChanged("_currentStepKillCount");
                }
            }
        }

        /// <summary>
        /// Gets the list of steps decriptions
        /// </summary>
        public List<string> _stepsDescription
        {
            get { return stepsDescription; }
        }

        /// <summary>
        /// Gets the list of whether or not this step completes quest
        /// </summary>
        public List<bool> _isCompletionStep
        {
            get { return stepsCompletesQuest; }
        }

        /// <summary>
        /// adds step data to corresponding lists and dictionary
        /// </summary>
        public void addStep()
        {
            stepNumber += 1;
            steps.Add("QS_" + stepNumber);
            stepsDescription.Add(currentStepDescription);
            stepsCompletesQuest.Add(currentStepCompletesQuest);
            if (currentStepType == "Kill")
            {
                stepsType.Add(currentStepType);
                stepsGoal.Add(stepsType.Count-1, currentStepKillCount);
            }
            else if(currentStepType == "Explore")
            {
                locNumber += 1;
                stepsType.Add(currentStepType);
                stepsGoal.Add(stepsType.Count-1, "LOC_" + locNumber);
            }
            else
            {
                convoNumber += 1;
                stepsType.Add(currentStepType);
                stepsGoal.Add(stepsType.Count-1, "CO_" + convoNumber);
            }
        }

        /// <summary>
        /// resets numbers used for incrementing
        /// </summary>
        public void resetIncrementers()
        {
            locNumber = 0;
            convoNumber = 0;
        }

        /// <summary>
        /// clears all lists
        /// </summary>
        public void clearLists()
        {
            stepsType.Clear();
            stepsGoal.Clear();
            steps.Clear();
            stepsDescription.Clear();
            stepsCompletesQuest.Clear();
        }

        /// <summary>
        /// Saves the quest data
        /// </summary>
        public void saveQuest()
        {
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
