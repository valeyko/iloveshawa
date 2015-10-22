﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILoveShawa.Domain.IRepository;

namespace ILoveShawa.Domain.Repository
{
    public class ShawaShopRepository : IShawaShopRepository
    {
        public void AddShawaShop(ShawaShop shawaShop)
        {
            using (var container = new ILoveShawaContainer())
            {
                container.ShawaShops.Add(shawaShop);
            }
        }

        public IEnumerable<ShawaShop> GetShawaShops()
        {
            using (var container = new ILoveShawaContainer())
            {
                return container.ShawaShops;
            }
        }

        public IEnumerable<ShawaShop> GetShawaShops(Predicate<ShawaShop> condition)
        {
            using (var container = new ILoveShawaContainer())
            {
                return container.ShawaShops.Where(x => condition(x));
            }
        }

        public ShawaShop GetShawaShop(int id)
        {
            using (var container = new ILoveShawaContainer())
            {
                return container.ShawaShops.FirstOrDefault(x => x.id == id);
            }
        }
    }
}
