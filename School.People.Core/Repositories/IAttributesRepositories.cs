using System;
using Apps.DataClient.Core;
using System.Collections.Generic;
using School.People.Core.Attributes;

namespace School.People.Core.Repositories
{
    public interface IPersonDetailsRepository : IReadAsync<Guid, IPersonDetails>, IUpdateAsync<IPersonDetails> { }
    public interface IFamilyIdsRepository : IReadAsync<Guid, IFamilyIds> { }
    public interface IEducationsRepository : IReadAsync<Guid, IEducation>, IInsertAsync<IEducation, Guid?>, IUpdateAsync<IEducation>, IDeleteAsync<IEducation> { }
    public interface IEligibilitiesRepository : IReadAsync<Guid, IEligibility>, IInsertAsync<IEligibility, Guid?>, IUpdateAsync<IEligibility>, IDeleteAsync<IEligibility> { }
    public interface IWorksRepository : IReadAsync<Guid, IWork>, IInsertAsync<IWork, Guid?>, IUpdateAsync<IWork>, IDeleteAsync<IWork> { }
    public interface ICivicWorksRepository : IReadAsync<Guid, ICivicWork>, IInsertAsync<ICivicWork, Guid?>, IUpdateAsync<ICivicWork>, IDeleteAsync<ICivicWork> { }
    public interface ITrainingsRepository : IReadAsync<Guid, ITraining>, IInsertAsync<ITraining, Guid?>, IUpdateAsync<ITraining>, IDeleteAsync<ITraining> { }
    public interface IOtherInformationsRepository : IReadAsync<Guid, IOtherInformation>, IInsertAsync<IOtherInformation, Guid?>, IUpdateAsync<IOtherInformation>, IDeleteAsync<IOtherInformation> { }
    public interface IFaqsRepository : IReadAsync<Guid, IFaqs>, IUpdateAsync<IFaqs> { }
    public interface ICharacterReferencesIdsRepository : IReadAsync<Guid, ICharacterReferencesIds>, IUpdateAsync<ICharacterReferencesIds> { }
    public interface IVerificationDetailsRepository : IReadAsync<Guid, IVerificationDetails>, IUpdateAsync<IVerificationDetails> { }

    public interface ICommentsRepository : IReadAsync<Guid, IComments>, IUpdateAsync<IComments>, IDeleteAsync<IComments> { }
    public interface IImagesRepository : IReadAsync<Guid, IIdPicture>, IUpdateAsync<IIdPicture> { }
    public interface IAgencyMemberDetailsRepository : IReadAsync<Guid, IAgencyMemberDetails>, IUpdateAsync<IAgencyMemberDetails> { }

    public interface IContactDetailsRepository : IReadAsync<Guid, IContactDetails>, IUpdateAsync<IContactDetails> { }
    public interface ICitizenshipsRepository : IReadAsync<Guid, ICitizenship>, IUpdateAsync<ICitizenship> { }
    public interface IDateOfBirthsRepository : IReadAsync<Guid, IDateOfBirth>, IUpdateAsync<IDateOfBirth> { }
    public interface IAddressIdsRepository : IReadAsync<Guid, IAddressIds>, IUpdateAsync<IAddressIds> { }

    public interface IMotherIdsRepository : IUpdateAsync<Guid, Guid, bool> { }
    public interface IFatherIdsRepository : IUpdateAsync<Guid, Guid, bool> { }
    public interface ISpouseIdsRepository : IUpdateAsync<Guid, Guid?, bool> { }
    public interface IChildrenIdsRepository : IReadAllAsync<Guid, Guid> { }
}
