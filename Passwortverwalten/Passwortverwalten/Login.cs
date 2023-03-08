using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwortverwalten;
internal class Login
{
    public string ID { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;

    public override string ToString()
    {
        return String.Format("{0}: {1}", this.Title, this.Username);
    }
}
