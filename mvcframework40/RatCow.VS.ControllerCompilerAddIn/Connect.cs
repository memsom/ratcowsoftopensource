using System;
using System.Collections.Generic;
using EnvDTE;
using EnvDTE80;
using Extensibility;
using Microsoft.VisualStudio.CommandBars;

namespace RatCow.VS.ControllerCompilerAddIn
{
  /// <summary>The object for implementing an Add-in.</summary>
  /// <seealso class='IDTExtensibility2' />
  public class Connect : IDTExtensibility2, IDTCommandTarget
  {
    /// <summary>Implements the constructor for the Add-in object. Place your initialization code within this method.</summary>
    public Connect()
    {
    }

    /// <summary>Implements the OnConnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being loaded.</summary>
    /// <param term='application'>Root object of the host application.</param>
    /// <param term='connectMode'>Describes how the Add-in is being loaded.</param>
    /// <param term='addInInst'>Object representing this Add-in.</param>
    /// <seealso class='IDTExtensibility2' />
    public void OnConnection( object application, ext_ConnectMode connectMode, object addInInst, ref Array custom )
    {
      _applicationObject = (DTE2)application;
      _addInInstance = (AddIn)addInInst;

      if ( connectMode == ext_ConnectMode.ext_cm_Startup )
      {
        var bindings = new Dictionary<string, object>();
        for ( var i = 1 ; i <= _applicationObject.Commands.Count ; i++ )
        {
          Command command = _applicationObject.Commands.Item( i );
          string name = command.Name;
          if ( name.StartsWith( "ControllerUpdater.Run", StringComparison.Ordinal ) )
          {
            name = name.Substring( "ControllerUpdater.Run".Length );
            bindings.Add( name, command.Bindings );
          }
        }
        foreach ( var pair in bindings )
        {
          _applicationObject.Commands.Item( "ControllerUpdater.Run" ).Delete();
        }

        //bool first = true;
        //int position = 1;
        //foreach ( var pair in Templates.OrderBy( t => t.Value.Position ) )
        //{
        //  object keyBinding;
        //  bindings.TryGetValue( pair.Key, out keyBinding );
        //  AddItemCommand( "New" + pair.Key, "Add " + pair.Value.Title, keyBinding, position++, pair.Value.FaceID, first );
        //  first = false;
        //}

        AddItemCommand( "Run", "Update controller", null, 1, 0, true );
      }
    }

    private void AddItemCommand( string name, string text, object bindings, int position, int faceId, bool beginGroup )
    {
      object[] contextGUIDS = new object[] { };
      Commands2 commands = (Commands2)_applicationObject.Commands;
      CommandBars commandBars = ( (CommandBars)_applicationObject.CommandBars );
      CommandBar[] targetBars = new CommandBar[] {
            commandBars["Folder"],
            commandBars["Project"]
        };

      try
      {
        Command command = commands.AddNamedCommand2( _addInInstance, name, text, null, true, faceId, ref contextGUIDS, (int)vsCommandStatus.vsCommandStatusSupported + (int)vsCommandStatus.vsCommandStatusEnabled, (int)vsCommandStyle.vsCommandStylePictAndText, vsCommandControlType.vsCommandControlTypeButton );
        if ( bindings != null )
        {
          command.Bindings = bindings;
        }
        if ( command != null )
        {
          foreach ( CommandBar bar in targetBars )
          {
            CommandBarButton button = (CommandBarButton)command.AddControl( bar, position );
            button.BeginGroup = beginGroup;
          }
        }
      }
      catch ( ArgumentException )
      {
      }
    }

    /// <summary>Implements the OnDisconnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being unloaded.</summary>
    /// <param term='disconnectMode'>Describes how the Add-in is being unloaded.</param>
    /// <param term='custom'>Array of parameters that are host application specific.</param>
    /// <seealso class='IDTExtensibility2' />
    public void OnDisconnection( ext_DisconnectMode disconnectMode, ref Array custom )
    {
    }

    /// <summary>Implements the OnAddInsUpdate method of the IDTExtensibility2 interface. Receives notification when the collection of Add-ins has changed.</summary>
    /// <param term='custom'>Array of parameters that are host application specific.</param>
    /// <seealso class='IDTExtensibility2' />
    public void OnAddInsUpdate( ref Array custom )
    {
    }

    /// <summary>Implements the OnStartupComplete method of the IDTExtensibility2 interface. Receives notification that the host application has completed loading.</summary>
    /// <param term='custom'>Array of parameters that are host application specific.</param>
    /// <seealso class='IDTExtensibility2' />
    public void OnStartupComplete( ref Array custom )
    {
    }

    /// <summary>Implements the OnBeginShutdown method of the IDTExtensibility2 interface. Receives notification that the host application is being unloaded.</summary>
    /// <param term='custom'>Array of parameters that are host application specific.</param>
    /// <seealso class='IDTExtensibility2' />
    public void OnBeginShutdown( ref Array custom )
    {
    }

    private DTE2 _applicationObject;
    private AddIn _addInInstance;

    #region IDTCommandTarget Members

    /// <summary>
    ///
    /// </summary>
    /// <param name="CmdName"></param>
    /// <param name="ExecuteOption"></param>
    /// <param name="VariantIn"></param>
    /// <param name="VariantOut"></param>
    /// <param name="Handled"></param>
    public void Exec( string CmdName, vsCommandExecOption ExecuteOption, ref object VariantIn, ref object VariantOut, ref bool Handled )
    {
      Handled = false;
      if ( ExecuteOption == vsCommandExecOption.vsCommandExecOptionDoDefault )
      {
        System.Diagnostics.Debug.WriteLine( CmdName );

        if ( CmdName.StartsWith( "ControllerUpdater.Run" ) )
        {
          //CmdName = CmdName.Substring( "ControllerUpdater.Run".Length );

          //run command
        }
      }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="CmdName"></param>
    /// <param name="NeededText"></param>
    /// <param name="StatusOption"></param>
    /// <param name="CommandText"></param>
    public void QueryStatus( string CmdName, vsCommandStatusTextWanted NeededText, ref vsCommandStatus StatusOption, ref object CommandText )
    {
      if ( NeededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone )
      {
        if ( CmdName.StartsWith( "ControllerUpdater.Run" ) )
        {
          StatusOption = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported | vsCommandStatus.vsCommandStatusEnabled;
          return;
        }
      }
    }

    #endregion
  }
}