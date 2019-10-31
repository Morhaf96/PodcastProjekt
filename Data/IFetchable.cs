﻿using PodcastProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastProjekt.Data
{
    interface IFetchable<T>
    {

        Podcast HamtaPodcast(Uri hamtaUrl);
    }
}
