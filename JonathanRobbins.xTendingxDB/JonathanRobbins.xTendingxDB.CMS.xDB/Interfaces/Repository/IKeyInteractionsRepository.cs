﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanRobbins.xTendingxDB.CMS.xDB.Entities;
using Sitecore.Analytics.Tracking;

namespace JonathanRobbins.xTendingxDB.CMS.xDB.Interfaces.Repository
{
    public interface IKeyInteractionsRepository
    {
        IEnumerable<BrochureDownload> GetBrochureDownloads(Contact contact);
        IEnumerable<SampleOrder> GetSampleOrders(Contact contact);
        IEnumerable<ImageGalleryViewed> GetGalleriesViewed(Contact contact);
        void Set(Contact contact, BrochureDownload brochureDownload);
        void Set(Contact contact, ImageGalleryViewed imageGalleryViewed);
        void Set(Contact contact, SampleOrder sampleOrder);
    }
}
