using School.People.Core.Attributes;
using System.Collections.Generic;
using Apps.Communication.Core;

namespace School.People.Core.Commands
{
    public interface ISaveMarriedAttributeCommand : ICommand<IMarried> { }
    public interface ISaveChildAttributeCommand : ICommand<IFamilyIds> { }
    public interface ISavePdsDetailsCommand : ICommand<IPdsDetails> { }
    public interface ISaveCommentsCommand : ICommand<IComments> { }
    public interface ISaveImageCommand : ICommand<IImage> { }
    public interface ISaveBirthdateCommand : ICommand<IDateOfBirth> { }
    public interface ISaveCharacterReferencesCommand : ICommand<ICharacterReferencesIds> { }
    public interface ISaveVerificationDetailsCommand : ICommand<IVerificationDetails> { }
    public interface ISaveFaqsCommand : ICommand<IFaqs> { }
    public interface ISaveOtherInformationsCommand : ICommand<IEnumerable<IOtherInformation>> { }
    public interface ISaveTrainingsCommand : ICommand<IEnumerable<ITraining>> { }
    public interface ISaveCivicWorksCommand : ICommand<IEnumerable<ICivicWork>> { }
    public interface ISaveRegularWorksCommand : ICommand<IEnumerable<IWork>> { }
    public interface ISaveEligibilitiesCommand : ICommand<IEnumerable<IEligibility>> { }
    public interface ISaveEducationsCommand : ICommand<IEnumerable<IEducation>> { }
    public interface ISavePersonalInformationCommand : ICommand<IPersonDetails> { }
}