using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public Genre Genre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    default: return false;
                }
            }
        }

        public StreamingContent() { }

        public StreamingContent(string title, string description, double starRating, Genre genre, MaturityRating maturityRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            Genre = genre;
            MaturityRating = maturityRating;
        }

    }
    public enum Genre
    {
        Horror = 1,
        RomCom,
        SciFi,
        Action,
        Documentary,
        Musical,
        Drama,
        Mystery
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17
    }
}
