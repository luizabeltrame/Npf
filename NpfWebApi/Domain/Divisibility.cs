using System;
using System.Collections.Generic;

namespace Domain
{
    public class Divisibility : IDivisibility
    {
        public Divisibility() {
        }

        public IEnumerable<NumberDetail> Get(IEnumerable<string> numbers)
        {
            try
            {
                IList<NumberDetail> numberDetails = new List<NumberDetail>();
                foreach (var number in numbers)
                {
                    NumberDetail numberDetail = new NumberDetail()
                    {
                        Number = number,
                        IsMultiple = Calculate(number)
                    };
                    numberDetails.Add(numberDetail);
                }

                return numberDetails;
            } 
            catch(Exception exception)
            {
                throw exception;
            }
        }

        private bool Calculate (string number)
        {   
            if (number.Length < 2)
            {
                return false;
            }

            if (number.Length == 2)
            {
                if (number[0] == number[1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int length = number.Length - 1;
            Int64 plot1 = Convert.ToInt64(number.Substring(0, length));
            Int64 plot2 = Convert.ToInt64(number[length].ToString());
            Int64 result = plot1 - plot2;
            return Calculate(Convert.ToString(result));
        }
    }
}
