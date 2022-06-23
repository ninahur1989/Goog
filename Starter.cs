﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3
{
    public class Starter
    {
        private Logger _logger = new Logger();
        private event Action WriterEvent;

        public async Task Start()
        {
            Logger logger = new Logger();
            logger.Config();
            WriterEvent = logger.FileWriterAsync;
            WriterEvent += logger.FileWriterAsync;
            WriterEvent.Invoke();
        }
    }
}
