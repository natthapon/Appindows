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
    /// start_LetsGo ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Istart_LetsGoViewModel
    {		
	    /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        Visibility IsInternetAvalaible { get; }
        /// <summary>
        /// Gets/Sets the SelectedLetsGoMenuControl property.
        /// </summary>
		Controls.MenuItemData SelectedLetsGoMenuControl { get; set; }
        /// <summary>
        /// Gets/Sets the Movie_VideosListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.YouTubeVideo> Movie_VideosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Movie_VideosListControlCollectionPageNumber property.
        /// </summary>
		int Movie_VideosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedMovie_VideosListControlCollection property.
        /// </summary>
		EntitiesBase.YouTubeVideo SelectedMovie_VideosListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshMovie_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshMovie_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetMovie_VideosListControlCollectionCommand command.
        /// </summary>
		ICommand GetMovie_VideosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}
