using MediaBrowser.Common.Configuration;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.IO;
using MediaBrowser.Model.Xml;
using Microsoft.Extensions.Logging;

namespace MediaBrowser.XbmcMetadata.Providers
{
    public class MovieNfoProvider : BaseVideoNfoProvider<Movie>
    {
        public MovieNfoProvider(IFileSystem fileSystem, ILogger logger, IConfigurationManager config, IProviderManager providerManager, IXmlReaderSettingsFactory xmlReaderSettingsFactory) : base(fileSystem, logger, config, providerManager, xmlReaderSettingsFactory)
        {
        }
    }

    public class MusicVideoNfoProvider : BaseVideoNfoProvider<MusicVideo>
    {
        public MusicVideoNfoProvider(IFileSystem fileSystem, ILogger logger, IConfigurationManager config, IProviderManager providerManager, IXmlReaderSettingsFactory xmlReaderSettingsFactory) : base(fileSystem, logger, config, providerManager, xmlReaderSettingsFactory)
        {
        }
    }

    public class VideoNfoProvider : BaseVideoNfoProvider<Video>
    {
        public VideoNfoProvider(IFileSystem fileSystem, ILogger logger, IConfigurationManager config, IProviderManager providerManager, IXmlReaderSettingsFactory xmlReaderSettingsFactory) : base(fileSystem, logger, config, providerManager, xmlReaderSettingsFactory)
        {
        }
    }
}
