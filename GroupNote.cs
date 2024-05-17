using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class GroupNote : Note
    {
        List<string> People = new List<string>();
        public GroupNote(string message, ITheme theme, List<string> People) : base(message, theme)
        {
            this.People = People;
        }
        public void AddPerson(string person)
        {
            this.People.Add(person);
        }
        public void RemovePerson(string person)
        {
            this.People.Remove(person);
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROUP NOTE: ");
            foreach (string person in this.People)
            {
                Console.WriteLine(person);
            }
            Console.ResetColor();
        }
    }
}
