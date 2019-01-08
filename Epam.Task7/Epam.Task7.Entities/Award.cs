using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    public class Award
    {
        private string id;
        private string title;

        public Award(string title)
        {
            this.id = $"A{DateTime.Now:ddMMyyyyHHmmssffff}";
            this.title = title;
        }

        public Award(string id, string title)
        {
            this.id = id;
            this.title = title;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
