﻿using System;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using Umbraco.Cms.Core.Services;


namespace Hifi.PositionalContent
{
    public abstract class PositionalContentModelBase
    {

     
        public virtual object content { get; set; }

        public virtual object settings { get; set; }

        [JsonIgnore]
        public virtual bool HasContent
        {
            get
            {
                return content != null && content.ToString() != string.Empty;
            }
        }

        [JsonIgnore]
        public virtual bool HasSettings
        {
            get
            {
                return settings != null && settings.ToString() != string.Empty;
            }
        }

        protected virtual T Content<T>(Guid dtdGuid, PositionalContentDataTypes type)
        {
            
            var contentService = PositionalContentContentServiceProvider.ServiceProvider.GetService<PositionalContentContentService>();
            return contentService.Value<T>(dtdGuid, content, type);
        }

        protected virtual T Settings<T>(Guid dtdGuid, PositionalContentDataTypes type)
        {
            var contentService = PositionalContentContentServiceProvider.ServiceProvider.GetService<PositionalContentContentService>();
            return contentService.Value<T>(dtdGuid, settings, type);
        }
    }

}

