using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository.Content
{
    // Challenge:
    // Change the getter for EpisodeCount to get the actual
        // number of episodes (no setter)
    // Add a Show with 2-3 episodes, and display the episode count
        // in the UI

    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public int EpisodeCount {
            get { return Episodes.Count; }
        }
        public double AverageRunTime { get; set; }
    }

    public class Episode
    {
        // backing field
        private string _title;
        // Property
        public string Title {
            get 
            {
                return _title;
            }
            set
            {
                if (value[0].ToString().ToLower() == value[0].ToString())
                {
                    string capitalizedTitle = "";
                    capitalizedTitle += value[0].ToString().ToUpper();
                    capitalizedTitle += value.Substring(1);
                    _title = capitalizedTitle;
                }
                else
                {
                    _title = value;
                }
            } 
        }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public Episode() { }
        public Episode(string title, double runTime, int season)
        {
            Title = title;
            RunTime = runTime;
            SeasonNumber = season;

        }
    }
}
