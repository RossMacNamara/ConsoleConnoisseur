using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public static class DbInitializer
    {

        public static void Seed(AppDbContext context)
        {
            if (!context.Consoles.Any())
            {

                context.AddRange
                (
                new Console { Brand = "Sony", Name = "PS2", Price = 59.99M, Released = 2000, About = "The PS2 is the best selling home console to date having reached over 155 million unis sold. Game saves are stored on external 8MB memory cards and controllers are wired.", ImgUrl = "https://dbhno0jmmrkal.cloudfront.net/article_title_large/cebf5b34ce0cef90bec6e266d0cdd95a.jpeg", ImgThumbnailUrl = "https://5.imimg.com/data5/TR/QG/MY-7628077/sony-ps2-console-500x500.jpg" },
                new Console { Brand = "Microsoft", Name = "Xbox", Price = 55.00M, Released = 2001, About = "Microsofts first console which directly competed with the PS2 only managing to sell 24 million. Game saves are stored on an internal harddrive and controllers are wired.", ImgUrl = "https://www.windowscentral.com/sites/wpcentral.com/files/styles/xlarge/public/field/image/2017/10/Xbox-original-720_0.jpg?itok=sXdjdqTj", ImgThumbnailUrl = "https://www.lifewire.com/thmb/IruGLQqf_qWxCVSXCeiGurY-GHw=/768x0/filters:no_upscale():max_bytes(150000):strip_icc()/x-box-731a722dbdca4e86919196e580b9385e.jpg" },
                new Console { Brand = "Nintendo", Name = "Gamecube", Price = 58.00M, Released = 2001, About = "The Gamecube was the successor to the Nintendo 64 selling just over 21 million units. Game saves are stored on external memory cards with three to choose from 512KB,2MB and 8MB. Controllers are wired.", ImgUrl = "https://cdn2.bigcommerce.com/server1300/30bbe/products/87/images/86/Gamecube_CONSOLE_-__indigo__87787.1281938409.1280.1280.jpg?c=2", ImgThumbnailUrl = "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/original/products/30993/21870/System%20Gamecube%20-%201-2__60109.1394748290.jpg?c=2&imbypass=on" },
                new Console { Brand = "Sega", Name = "Dreamcast", Price = 65.00M, Released = 1998, About = "The Dreamcast was the first sixth gen console and also Sega's last console selling just over 9 million units. Games are saved on memory cards with three sizes 128KB, 256KB and 512KB. They use wired controllers.", ImgUrl = "https://cdn11.bigcommerce.com/s-kzjsut/images/stencil/1280x1280/products/1459/3168/PAL_SECAM_SEGA_Dreamcast_HKT-3030_PAL_E__72378.1512244016.jpg?c=2&imbypass=on", ImgThumbnailUrl = "https://cdn11.bigcommerce.com/s-kzjsut/images/stencil/1280x1280/products/1459/3168/PAL_SECAM_SEGA_Dreamcast_HKT-3030_PAL_E__72378.1512244016.jpg?c=2&imbypass=on?imbypass=on" },
                new Console { Brand = "Atari", Name = "Jaguar", Price = 140.00M, Released = 1993, About = "The sixth console from Atari it was also the last Atari console to use physical media. It sold less than 250,000 units.The multi-chip architecture, hardware bugs, and lacking developer support tools made game development difficult.", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Atari-Jaguar-CD-wPro-Controller.jpg/1200px-Atari-Jaguar-CD-wPro-Controller.jpg", ImgThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTo7JM_K1fHNRpij1if2lFiBNMfPvmgLo55rsqmDH6RnGOE2Usj" },
                new Console { Brand = "Sega", Name = "Genesis", Price = 35.00M, Released = 1988, About = "The Sega Genesis, known as the Mega Drive[b] in regions outside of North America, is a 16-bit home video game console developed and sold by Sega. The Genesis was Sega's third console and the successor to the Master System. It sold over 30 million units.", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a1/Sega-Mega-Drive-JP-Mk1-Console-Set.jpg", ImgThumbnailUrl = "https://tshop.r10s.com/d1f/9df/3c51/a6f2/104b/9498/7789/1191e79bf554ab3a2954fe.jpg" },
                new Console { Brand = "Sony", Name = "PS1", Price = 28.00M, Released = 1994, About = "The PlayStation was the first computer entertainment platform to ship over 100 million units, which it had reached nine years after its initial launch.[9] In July 2000, a redesigned, slim version called the PS one was released, replacing the original grey console and named appropriately to avoid confusion with its successor, the PlayStation 2.", ImgUrl = "https://images-na.ssl-images-amazon.com/images/I/612eHK46YJL._SL1500_.jpg", ImgThumbnailUrl = "https://cdn.ndtv.com/tech/gadgets/playstation_one_sony.jpg?output-quality=80" },
                new Console { Brand = "Nintendo", Name = "64", Price = 30.00M, Released = 1996, About = "The Nintendo 64  is a home video game console developed and marketed by Nintendo. Named for its 64-bit central processing unit.Codenamed Project Reality, the Nintendo 64 design was mostly complete by mid-1995, but its launch was delayed until 1996, when Time named it Machine of the Year. Sold over 32 million units.", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/1/11/N64-Console-Set.jpg", ImgThumbnailUrl = "https://i5.walmartimages.com/asr/ceaea6e4-9b48-4bb5-90a6-58f47dc059ca_1.e0cc231827e33a186706b4616659e6a4.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF" },
                new Console { Brand = "Nintendo", Name = "SNES", Price = 75.00M, Released = 1990, About = "The Super Nintendo Entertainment System (SNES) is a 16-bit home video game console.The SNES is Nintendo's second programmable home console, following the Nintendo Entertainment System (NES). The console introduced advanced graphics and sound capabilities compared with other systems at the time. The development of a variety of enhancement chips integrated in game cartridges helped to keep it competitive in the marketplace. Sold 49 million units.", ImgUrl = "https://www.courts.com.sg/media/catalog/product/cache/image/877dc93997714d8128364ed469e79c36/i/p/ip127649_01.jpg", ImgThumbnailUrl = "https://cdn11.bigcommerce.com/s-ymgqt/products/31219/images/31180/snes_2_player_pak__42077.1456502566.500.750.jpg?c=2" }
                );
            }
            context.SaveChanges();
        }
    }
}
