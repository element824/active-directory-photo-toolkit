﻿using System.DirectoryServices.AccountManagement;

namespace ActiveDirectoryPhotoToolkit
{
    internal interface IActiveDirectoryPhoto
    {
        Thumbnail GetThumbnailPhoto(string userName, ActiveDirectoryPhoto.Format format);
        void SetThumbnailPhoto(string userName, string thumbNailLocation);
        void SaveThumbnailToDisk(Thumbnail thumbnail);
        void SaveThumbnailToDisk(Thumbnail thumbnail, string location);
    }
}