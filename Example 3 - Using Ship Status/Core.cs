﻿using EliteAPI.Abstractions;

using Microsoft.Extensions.Logging;

using System.Threading.Tasks;

namespace Example3
{
    // Core class of our application
    public class Core
    {
        private readonly ILogger<Core> _log;
        private readonly IEliteDangerousAPI _api;

        public Core(ILogger<Core> log, IEliteDangerousAPI api)
        {
            // Get our dependencies through dependency injection
            _log = log;
            _api = api;
        }

        public async Task Run()
        {
            // Log to the logging system whenever we change our gear
            _api.Status.Gear.OnChange += (sender, isDeployed) =>
            {
                string message = "";

                if (isDeployed)
                {
                    message = "Landing gears deployed";
                }
                else
                {
                    message = "Landing gears retracted";
                }

                _log.LogInformation(message);
            };

            // Start EliteAPI
            await _api.StartAsync();

        }
    }
}