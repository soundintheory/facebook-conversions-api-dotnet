/*
 * Facebook Conversions API (for Web)
 *
 * The Conversions API (for web) allows advertisers to send web events from their servers directly to Facebook. Conversions API events are linked to a pixel and are processed like browser pixel events. This means that these conversion events are used in measurement, reporting, and optimization in the same way as browser pixel events.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: web_signals_integrations@fb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;

namespace SoundInTheory.Facebook.ConversionsAPI.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        String GetBasePath();

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }
    }
}
