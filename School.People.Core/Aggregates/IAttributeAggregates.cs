using School.People.Core.Attributes;
using System.Collections.Generic;

namespace School.People.Core.Aggregates
{
    public interface IPersonalInformationAggregate : IAttribute, IPersonalInformation, IDateOfBirth, IContactDetails, IAgencyMemberIdentifier, IAddressIds { }
    public interface IFamilyBackgroundAggregate : IAttribute, IEnumerable<IPerson> { }
    public interface IEducationalBackgroundAggregate : IAttribute, IEnumerable<IEducation> { }
    public interface IWorkExperienceAggregate : IAttribute, IEnumerable<IRegularWork> { }
    public interface ICivicWorksAggregate : IAttribute, IEnumerable<ICivicWork> { }
    public interface ITrainingsAggregate : IAttribute, IEnumerable<ITraining> { }
    public interface IOtherInformationAggregate : IAttribute, IEnumerable<IOtherInformation> { }
}
