// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A definition of the range of ages accepted by a clinical trial. Contains a minimum age and/or a maximum age. </summary>
    public partial class AcceptedAgeRange
    {
        /// <summary> Initializes a new instance of AcceptedAgeRange. </summary>
        public AcceptedAgeRange()
        {
        }

        /// <summary> Initializes a new instance of AcceptedAgeRange. </summary>
        /// <param name="minimumAge"> A person's age, given as a number (value) and a unit (e.g. years, months). </param>
        /// <param name="maximumAge"> A person's age, given as a number (value) and a unit (e.g. years, months). </param>
        internal AcceptedAgeRange(AcceptedAge minimumAge, AcceptedAge maximumAge)
        {
            MinimumAge = minimumAge;
            MaximumAge = maximumAge;
        }

        /// <summary> A person's age, given as a number (value) and a unit (e.g. years, months). </summary>
        public AcceptedAge MinimumAge { get; set; }
        /// <summary> A person's age, given as a number (value) and a unit (e.g. years, months). </summary>
        public AcceptedAge MaximumAge { get; set; }
    }
}
