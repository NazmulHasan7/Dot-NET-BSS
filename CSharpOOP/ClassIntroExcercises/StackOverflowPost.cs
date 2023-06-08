using System;

namespace CSharpOOP.ClassIntroExcercises
{
    public class StackOverflowPost
    {
        private int _vote = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Vote { get { return _vote; } }

        public StackOverflowPost(string title, string description)
        {
            CreatedOn = DateTime.Now;
            Title = title;
            Description = description;
        }
        public void UpVote()
        {
            _vote++;
        }
        public void DownVote()
        {
            _vote--;
        }
    }
}