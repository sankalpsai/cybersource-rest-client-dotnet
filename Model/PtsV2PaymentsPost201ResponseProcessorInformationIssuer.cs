/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsPost201ResponseProcessorInformationIssuer
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseProcessorInformationIssuer :  IEquatable<PtsV2PaymentsPost201ResponseProcessorInformationIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseProcessorInformationIssuer" /> class.
        /// </summary>
        /// <param name="Country">Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions. .</param>
        /// <param name="DiscretionaryData">Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. .</param>
        public PtsV2PaymentsPost201ResponseProcessorInformationIssuer(string Country = default(string), string DiscretionaryData = default(string))
        {
            this.Country = Country;
            this.DiscretionaryData = DiscretionaryData;
        }
        
        /// <summary>
        /// Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions. 
        /// </summary>
        /// <value>Country in which the card was issued. This information enables you to determine whether the card was issued domestically or internationally. Use the two-character ISO Standard Country Codes.  This field is supported for Visa, Mastercard, Discover, Diners Club, JCB, and Maestro (International) on Chase Paymentech Solutions. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. 
        /// </summary>
        /// <value>Data defined by the issuer. The value for this reply field will probably be the same as the value that you submitted in the authorization request, but it is possible for the processor, issuer, or acquirer to modify the value.  This field is supported only for Visa transactions on **CyberSource through VisaNet**. </value>
        [DataMember(Name="discretionaryData", EmitDefaultValue=false)]
        public string DiscretionaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseProcessorInformationIssuer {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DiscretionaryData: ").Append(DiscretionaryData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsPost201ResponseProcessorInformationIssuer);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseProcessorInformationIssuer instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseProcessorInformationIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseProcessorInformationIssuer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.DiscretionaryData == other.DiscretionaryData ||
                    this.DiscretionaryData != null &&
                    this.DiscretionaryData.Equals(other.DiscretionaryData)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.DiscretionaryData != null)
                    hash = hash * 59 + this.DiscretionaryData.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 3.", new [] { "Country" });
            }

            // DiscretionaryData (string) maxLength
            if(this.DiscretionaryData != null && this.DiscretionaryData.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscretionaryData, length must be less than 255.", new [] { "DiscretionaryData" });
            }

            yield break;
        }
    }

}
