using System;

namespace Tavisca.Applause
{
    public class MonthYearValidationStrategy : IValidationStrategy<MonthYearAdditionalParameters>
    {
        MonthYearAdditionalParameters additionalParameters = new MonthYearAdditionalParameters();

        public MonthYearAdditionalParameters SetAdditionalParameters()
        {
            additionalParameters.Year = DateTime.Today.Year;
            additionalParameters.Month = DateTime.Today.Month;

            return GenerateAdditionalParameters();
        }

        public MonthYearAdditionalParameters SetAdditionalParameters(MonthYearAdditionalParameters additionalParams)
        {
            additionalParameters.Year = additionalParams.Year;
            additionalParameters.Month = additionalParams.Month;

            return GenerateAdditionalParameters();
        }

        public MonthYearAdditionalParameters UpdateAdditionalParameters()
        {
            if (additionalParameters.Month > 1)
            {
                additionalParameters.Month--;
            }
            else
            {
                additionalParameters.Year--;
                additionalParameters.Month = 12;
            }
            return GenerateAdditionalParameters();
        }

        public MonthYearAdditionalParameters GenerateAdditionalParameters()
        {
            return additionalParameters;
        }
    }
}