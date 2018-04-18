using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestOperations
{
    public class CucumbersTransform : IValueRetriever
    {
        [StepArgumentTransformation]
        public IEnumerable<Cucumber> CucumbersTransfer(Table cucumbers)
        {
            return cucumbers.CreateSet<Cucumber>();
        }

        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            if (propertyType != typeof(Table))
            {
                return false;
            }

            if (targetType != typeof(IEnumerable<Cucumber>))
            {
                return false;
            }

            return true;
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            throw new NotImplementedException();
        }
    }
}
