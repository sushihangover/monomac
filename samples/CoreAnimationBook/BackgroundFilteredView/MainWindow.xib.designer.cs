// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace BackgroundFilteredView {
	
	
	// Should subclass MonoMac.AppKit.NSView
	[MonoMac.Foundation.Register("BackgroundFilteredView")]
	public partial class BackgroundFilteredView {
		
		private global::MonoMac.AppKit.NSView __mt_controls;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("addFilter:")]
		partial void AddFilter (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("removeFilter:")]
		partial void RemoveFilter (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Connect("controls")]
		private global::MonoMac.AppKit.NSView controls {
			get {
				this.__mt_controls = ((global::MonoMac.AppKit.NSView)(this.GetNativeField("controls")));
				return this.__mt_controls;
			}
			set {
				this.__mt_controls = value;
				this.SetNativeField("controls", value);
			}
		}
	}
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
	}
}
