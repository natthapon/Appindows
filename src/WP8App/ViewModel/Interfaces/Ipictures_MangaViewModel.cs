// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// pictures_Manga ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Ipictures_MangaViewModel
    {		
        /// <summary>
        /// Gets/Sets the Pictures_MangaListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Pictures_MangaListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedpictures_MangaListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult Selectedpictures_MangaListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the Refreshpictures_MangaListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshpictures_MangaListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getpictures_MangaListControlCollectionCommand command.
        /// </summary>
		ICommand Getpictures_MangaListControlCollectionCommand { get; }

	}
}
