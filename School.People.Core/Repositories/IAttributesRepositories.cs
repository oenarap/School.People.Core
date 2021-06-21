using System;
using Apps.DataClient.Core;
using System.Collections.Generic;
using School.People.Core.Attributes;

namespace School.People.Core.Repositories
{
    public interface IBirthAddressIdsRepository : IReadAsync<Guid, IIdLink>, IInsertAsync<Guid, IIdLink, IIdLink>, IUpdateAsync<IIdLink> { }
    public interface IResidentialAddressIdsRepository : IReadAsync<Guid, IIdLink>, IInsertAsync<Guid, IIdLink, IIdLink>, IUpdateAsync<IIdLink> { }
    public interface IBusinessAddressIdsRepository : IReadAsync<Guid, IIdLink>, IInsertAsync<Guid, IIdLink, IIdLink>, IUpdateAsync<IIdLink> { }
    public interface IPermanentAddressIdsRepository : IReadAsync<Guid, IIdLink>, IInsertAsync<Guid, IIdLink, IIdLink>, IUpdateAsync<IIdLink> { }
    public interface ICommunityTaxCertificateIssuanceAddressIdsRepository : IReadAsync<Guid, IIdLink>, IInsertAsync<Guid, IIdLink, IIdLink>, IUpdateAsync<IIdLink> { }

    public interface IOtherInformationsRepository : IReadAsync<Guid, IEnumerable<IOtherInformation>>, IInsertRangeAsync<IOtherInformation>, IInsertAsync<IOtherInformation>, IUpdateAsync<IOtherInformation> { }
    public interface ITrainingsRepository : IReadAsync<Guid, IEnumerable<ITraining>>, IInsertRangeAsync<ITraining>, IInsertAsync<ITraining>, IUpdateAsync<ITraining> { }
    public interface ICivicWorksRepository : IReadAsync<Guid, IEnumerable<ICivicWork>>, IInsertRangeAsync<ICivicWork>, IInsertAsync<ICivicWork>, IUpdateAsync<ICivicWork> { }
    public interface IRegularWorksRepository : IReadAsync<Guid, IEnumerable<IRegularWork>>, IInsertRangeAsync<IRegularWork>, IInsertAsync<IRegularWork>, IUpdateAsync<IRegularWork> { }
    public interface IEligibilitiesRepository : IReadAsync<Guid, IEnumerable<IEligibility>>, IInsertRangeAsync<IEligibility>, IInsertAsync<IEligibility>, IUpdateAsync<IEligibility> { }
    public interface IEducationsRepository : IReadAsync<Guid, IEnumerable<IEducation>>, IInsertRangeAsync<IEducation>, IInsertAsync<IEducation>, IUpdateAsync<IEducation> { }
    
    public interface IMarriedAttributesRepository : IReadAsync<Guid, IMarried>, IUpdateAsync<Guid, IMarried, bool> { }
    public interface IChildAttributesRepository : IReadAsync<Guid, IChild>, IUpdateAsync<Guid, IChild, bool> { }
    public interface IPdsDetailsRepository : IReadAsync<Guid, IPdsDetails>, IUpdateAsync<Guid, IPdsDetails, bool> { }
    public interface ICommentsRepository : IReadAsync<Guid, IComments>, IUpdateAsync<Guid, IComments, bool> { }
    public interface IImagesRepository : IReadAsync<Guid, IImage>, IUpdateAsync<Guid, IImage, bool> { }
    public interface IAgencyIdsRepository : IReadAsync<Guid, IAgencyMemberIdentifier>, IUpdateAsync<Guid, IAgencyMemberIdentifier, bool> { }
    public interface IBirthdateAttributesRepository : IReadAsync<Guid, IDateOfBirth>, IUpdateAsync<Guid, IDateOfBirth, bool> { }
    public interface ICharacterReferencesRepository : IReadAsync<Guid, ICharacterReferences>, IUpdateAsync<Guid, ICharacterReferences, bool> { }
    public interface IVerificationDetailsRepository : IReadAsync<Guid, IVerificationDetails>, IUpdateAsync<Guid, IVerificationDetails, bool> { }
    public interface IFaqsRepository : IReadAsync<Guid, IFaqs>, IUpdateAsync<Guid, IFaqs, bool> { }
    public interface IPersonalInformationsRepository : IReadAsync<Guid, IPersonalInformation>, IUpdateAsync<Guid, IPersonalInformation, bool> { }
}
