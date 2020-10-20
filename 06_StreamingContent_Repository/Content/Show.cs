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
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
