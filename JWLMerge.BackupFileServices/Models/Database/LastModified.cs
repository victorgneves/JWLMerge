﻿namespace JWLMerge.BackupFileServices.Models.Database
{
    using Newtonsoft.Json;

    public class LastModified
    {
        /// <summary>
        /// Time stamp when the database was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "LastModified")]
        public string TimeLastModified { get; set; }
    }
}
