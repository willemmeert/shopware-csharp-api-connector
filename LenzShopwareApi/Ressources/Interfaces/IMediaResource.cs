﻿using System;
using System.Collections.Generic;
using Lenz.ShopwareApi.Models.Images;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Ressources
{
    public interface IMediaResource
    {
        List<Media> getAll();

        Media get(int id);

        ApiPostResponse add(Media media, string file);

        void delete(int id);
    }
}