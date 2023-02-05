using Session_16.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Storage {
    public class PetShopFileStorage : IFileStorage<PetShop> {
        public PetShop Load() {
            Serializer serializer = new Serializer();
            PetShop petShop = serializer.DeserializeFromFile<PetShop>("PetShop.json");
            return petShop;
        }

        public void Save(PetShop _petShop) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_petShop, "PetShop.json");           
        }
    }
}
