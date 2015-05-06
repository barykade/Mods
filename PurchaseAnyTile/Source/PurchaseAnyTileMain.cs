using ICities;
using UnityEngine;

namespace PurchaseAnyTileNamespace
{
    public class PurchaseAnyTileMain: IUserMod
    {
        public string Name {
            get { return "Purchase Any Tile"; }
        }

        public string Description {
            get { return "When purchasing a new tile, the tile does not have to be adjacent to another to be purchased"; }
        }
    }
}
