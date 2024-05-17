using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    public class LoginProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        private ConsoleLogger logger;

        public LoginProxyDataset(string filePath)
        {
            this.filePath = filePath;
            this.logger = ConsoleLogger.Instance;
        }

        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            logger.Log("User accessed the dataset.");
            
            return dataset.GetData();
        }
    }
}
