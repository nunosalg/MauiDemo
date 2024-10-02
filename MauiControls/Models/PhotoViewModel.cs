using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class PhotoViewModel
    {
        public ObservableCollection<Photo> photos { get; private set; }
        public ObservableCollection<Photo> Photos
        {
            get { return photos; }
            set { photos = value; }
        }

        public PhotoViewModel()
        {
            Photos = new ObservableCollection<Photo>()
            {
                new Photo() {Name = "Andromeda", ImageUrl = "andromeda.jpeg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpeg"},
                new Photo() {Name = "Universe", ImageUrl = "universe.jpeg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpeg"},
                new Photo() {Name = "Sombrero", ImageUrl = "galaxy5.jpeg"},
                new Photo() {Name = "Andromeda", ImageUrl = "andromeda.jpeg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpeg"},
                new Photo() {Name = "Universe", ImageUrl = "universe.jpeg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpeg"},
                new Photo() {Name = "Sombrero", ImageUrl = "galaxy5.jpeg"},
                new Photo() {Name = "Andromeda", ImageUrl = "andromeda.jpeg"},
                new Photo() {Name = "Milky Way", ImageUrl = "milkyway.jpeg"},
                new Photo() {Name = "Universe", ImageUrl = "universe.jpeg"},
                new Photo() {Name = "Galaxy", ImageUrl = "galaxy.jpeg"},
                new Photo() {Name = "Sombrero", ImageUrl = "galaxy5.jpeg"},
            };
        }
    }
}
