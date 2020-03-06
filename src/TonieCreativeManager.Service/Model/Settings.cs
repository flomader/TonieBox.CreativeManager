﻿using System.Collections.Generic;

namespace TonieCreativeManager.Service.Model
{
    public class Settings
    {
        public IEnumerable<string> MediaFileExtensions { get; set; }
        public IEnumerable<string> FolderCoverFiles { get; set; }
        public string LibraryRoot { get; set; }
        public IEnumerable<string> IgnoreFolderNames { get; set; }
        public string RepositoryDataFile { get; set; }
        public bool EnableShop { get; set; }
        public IEnumerable<string> KeyboardCharacters { get; set; }
        public string MarkAsBoughtFilename { get; set; }
        public int MediaItemCost { get; set; }
    }
}
