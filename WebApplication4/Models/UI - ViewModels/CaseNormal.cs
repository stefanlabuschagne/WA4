using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web.Mvc;


// VIEWModel for Creating a Case 
// And Defining all the UI Constraints for the Screen.

namespace WebApplication4.UIModels
{



    // https://stackoverflow.com/questions/11064316/what-is-viewmodel-in-mvc

   
    public class SearchCaller
    { }


    public class SearchCalls
    { }



    // THE CLASSNAME CANNOT BE THE SAME AS THE EF CLASSES IN THE SAME ASSEMBLY (Webapplication4)
    // TO RESOLVE THIS, WE NEED TO CEEATE A SEPARATE ASSEMBLY (Destop Application for the DATABASE MODELS in ENTITY FRAMEWORK)
    // Or Hack it this way.
    // This is for adding and editing a Counsellor
    public class CounsellorUI
    {
        [Required, MinLength(6)]
        public string Counsellor1 { get; set; }  // Because it cant be the same as the Classname
        public bool Active { get; set; }

    }



    // This is A UI VIEW-Model to Create Cases
    public class CaseNormal

    {

        // public CaseNormal { get; set; }


        [Required, Display(Name = "First Name")]
        public string Name { get; set; }
        [Required, Display(Name = "SurName")]
        public string Surname { get; set; }

        [Display(Name="Age Group")]
        public string Age { get; set; }

        [Required, Display(Name = "Gender")]
        public string Sex { get; set; }

        [Required]
        public string Race { get; set; }

        public string Occupation { get; set; }
        public string MedicalAid { get; set; }

        public string Medication { get; set; }


        public string Address { get; set; }


        public string City { get; set; }


        public string Province { get; set; }
        public string PostalCode { get; set; }

        [Required]
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }

        [Required, Display(Name = "E-Mail"), EmailAddress]
        public string EmailAddress { get; set; }


        public string Suburb { get; set; }

        public string DLLocation { get; set; }

        public string DLType { get; set; }

        public string DLSource { get; set; }

        public string DLStudentNumber { get; set; }

        [Required]
        public string Counsellor { get; set; }

        // DatePicker on UI
        [Required]
        public Nullable<System.DateTime> CallDate { get; set; }

        public bool ReasonADHD { get; set; }
        public bool  ReasonAlzheimersDementia { get; set; }
        public bool  ReasonAnxiety { get; set; }
        public bool  ReasonBipolar { get; set; }
        public bool  ReasonDebtPovertyUnemployment { get; set; }
        public bool  ReasonDepression { get; set; }
        public bool  ReasonEatingDisoirder { get; set; }
        public bool  ReasonHIVAIDS { get; set; }
        public bool  ReasonInformation { get; set; }
        public bool  ReasonLossGriefLoneliness { get; set; }
        public bool  ReasonNone { get; set; }
        public bool  ReasonOCD { get; set; }
        public bool  ReasonOtherIllness { get; set; }
        public bool  ReasonPhysicalEmotionalAbuse { get; set; }
        public bool  ReasonPostNatalDepression { get; set; }
        public bool  ReasonPTSDTrauma { get; set; }
        public bool  ReasonReationshipDomesticAbuse { get; set; }
        public bool  ReasonSchizophrenia { get; set; }
        public bool  ReasonSelfMutilation { get; set; }
        public bool  ReasonSexualAbuseRape { get; set; }
        public bool  ReasonSleepingDisorder { get; set; }
        public bool  ReasonSocialPhobia { get; set; }
        public bool  ReasonStress { get; set; }
        public bool  ReasonSubstanceAbuse { get; set; }
        public bool  ReasonSuicide { get; set; }
        public bool  ReferDASGFaceToFace { get; set; }
        public bool  ReferGP { get; set; }
        public bool  ReferGovHospital { get; set; }
        public bool  ReferLiteratureWebsite { get; set; }
        public bool  ReferNone { get; set; }
        public bool  ReferOther { get; set; }
        public bool  ReferOtherNGOHelpline { get; set; }
        public bool  ReferPoliceStation { get; set; }
        public bool  ReferPrivateHospital { get; set; }
        public bool  ReferPsychiatrist { get; set; }
        public bool  ReferPsychologist { get; set; }
        public bool  ReferRapeCrisis { get; set; }
        public bool  ReferShelter { get; set; }
        public bool  ReferSocialWorker { get; set; }
        public bool  ReferSupportGroup { get; set; }
        public bool  ReferTraumaCentre { get; set; }

        [Required, MaxLength(2000)]
        public string CallSummary { get; set; }

        public bool  ReasonFrequentCaller { get; set; }
        public bool  ReasonBullying { get; set; }
        public bool  ReasonPregnancy { get; set; }
        public bool  ReasonSexuality { get; set; }
        public bool  ReferRehabilitationCentre { get; set; }
        public bool  ReasonBorderlinePersonalityDisorder { get; set; }

        [Required]
        public string HelpLine { get; set; }


        public bool  ReasonOtherReason { get; set; }
        public bool  ReasonFollowUp { get; set; }
        public bool  ReferUniversityStudentWellness { get; set; }
        public bool  ReferSadagHelpLine { get; set; }
        public bool  ReferSelfHelp { get; set; }
        public bool  ReferUber { get; set; }

        // Dropdown
        [Required]
        public string DLCallTimeOfDay { get; set; }

        // Dropdown 
        public string CalledOnBehalfOf { get; set; }


        [Required, MinLength(100)]
        public string ActionPoints { get; set; }

        public bool  ReasonRelationshipRomanticIssues { get; set; }
        public bool  ReasonRelationshipFamilyIssues { get; set; }
        public bool  ReferCompanyEAP { get; set; }
        public bool  ReferUniversitySupportServices { get; set; }

        [Required, DefaultValue(3),Range(1,5)]
        public int DistressRatingBegining { get; set; }

        [Required, DefaultValue(3),Range(1,5)]
        public int DistressRatingEnd { get; set; }

    }

    public class CaseDedicaledLine
    {
        [Required, Display(Name = "The First Name")]
        public string Name { get; set; }
    }




}

