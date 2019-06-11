using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class ConsoleServices : IConsoleRepository
    {
        private List<Console> _consoles;

        public ConsoleServices()
        {
            if (_consoles == null)
            {
                InitializeConsoles();
            }
        }

        private void InitializeConsoles()
        {
            _consoles = new List<Console>
            {
                new Console {Id = 1, Brand = "Sony", Name = "PS2", Price = 59.99M, Released = 2000, About = "The PS2 is the best selling home console to date having reached over 155 million unis sold. Game saves are stored on external 8MB memory cards and controllers are wired.", ImgUrl = "https://dbhno0jmmrkal.cloudfront.net/article_title_large/cebf5b34ce0cef90bec6e266d0cdd95a.jpeg", ImgThumbnailUrl = "https://5.imimg.com/data5/TR/QG/MY-7628077/sony-ps2-console-500x500.jpg"},
                new Console {Id = 2, Brand = "Microsoft", Name = "Xbox", Price = 55.00M, Released = 2001, About = "Microsofts first console which directly competed with the PS2 only managing to sell 24 million. Game saves are stored on an internal harddrive and controllers are wired.", ImgUrl = "https://www.windowscentral.com/sites/wpcentral.com/files/styles/xlarge/public/field/image/2017/10/Xbox-original-720_0.jpg?itok=sXdjdqTj", ImgThumbnailUrl = "https://www.lifewire.com/thmb/IruGLQqf_qWxCVSXCeiGurY-GHw=/768x0/filters:no_upscale():max_bytes(150000):strip_icc()/x-box-731a722dbdca4e86919196e580b9385e.jpg"},
                new Console {Id = 3, Brand = "Nintendo", Name = "Gamecube", Price = 58.00M, Released = 2001, About = "The Gamecube was the successor to the Nintendo 64 selling just over 21 million units. Game saves are stored on external memory cards with three to choose from 512KB,2MB and 8MB. Controllers are wired.", ImgUrl = "https://cdn2.bigcommerce.com/server1300/30bbe/products/87/images/86/Gamecube_CONSOLE_-__indigo__87787.1281938409.1280.1280.jpg?c=2", ImgThumbnailUrl = "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/original/products/30993/21870/System%20Gamecube%20-%201-2__60109.1394748290.jpg?c=2&imbypass=on"},
                new Console {Id = 4, Brand = "Sega", Name = "Dreamcast", Price = 65.00M, Released = 1998, About = "The Dreamcast was the first sixth gen console and also Sega's last ome console selling just over 9 million units. Games are saved on memory cards with three sizes 128KB, 256KB and 512KB. They use wired controllers.", ImgUrl = "https://cdn11.bigcommerce.com/s-kzjsut/images/stencil/1280x1280/products/1459/3168/PAL_SECAM_SEGA_Dreamcast_HKT-3030_PAL_E__72378.1512244016.jpg?c=2&imbypass=on", ImgThumbnailUrl = "https://cdn11.bigcommerce.com/s-kzjsut/images/stencil/1280x1280/products/1459/3168/PAL_SECAM_SEGA_Dreamcast_HKT-3030_PAL_E__72378.1512244016.jpg?c=2&imbypass=on?imbypass=on"}
            };
        }

        public IEnumerable<Console> GetAllConsoles()
        {
            return _consoles;
        }

        public Console GetConsoleById(int consoleId)
        {
            return _consoles.FirstOrDefault(c => c.Id == consoleId);
        }
    }
}
