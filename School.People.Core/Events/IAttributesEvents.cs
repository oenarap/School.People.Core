using School.People.Core.Attributes;
using System.Collections.Generic;
using Apps.Communication.Core;

namespace School.People.Core.Events
{
    public interface IOtherInformationsSavedEvent : IEvent<IEnumerable<IOtherInformation>> { }
    public interface ITrainingsSavedEvent : IEvent<IEnumerable<ITraining>> { }
    public interface ICivicWorksSavedEvent : IEvent<IEnumerable<ICivicWork>> { }
    public interface IRegularWorksSavedEvent : IEvent<IEnumerable<IWork>> { }
    public interface IEligibilitiesSavedEvent : IEvent<IEnumerable<IEligibility>> { }
    public interface IEducationsSavedEvent : IEvent<IEnumerable<IEducation>> { }

    public interface IMarriedAttributeUpdatedEvent : IEvent<IMarried> { }
    public interface IChildAttributeUpdatedEvent : IEvent<IFamilyIds> { }
    public interface IPdsDetailsUpdatedEvent : IEvent<IPdsDetails> { }
    public interface ICommentsUpdatedEvent : IEvent<IComments> { }
    public interface IImageUpdatedEvent : IEvent<IIdPicture> { }
    public interface IBirthdateUpdatedEvent : IEvent<IDateOfBirth> { }
    public interface ICharacterReferencesUpdatedEvent : IEvent<ICharacterReferencesIds> { }
    public interface IVerificationDetailsUpdatedEvent : IEvent<IVerificationDetails> { }
    public interface IFaqsUpdatedEvent : IEvent<IFaqs> { }
    public interface IPersonalInformationUpdatedEvent : IEvent<IPersonDetails> { }
}
