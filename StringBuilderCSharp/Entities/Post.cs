using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilderCSharp.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Like { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int like)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Like = like;
        }

        public void AddComment(Comment comment)
        {
            Comment.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comment.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Like);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment comment in Comment)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }
    }
}
