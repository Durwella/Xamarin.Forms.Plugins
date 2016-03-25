using System.Reflection;
using Xamarin.Forms;

namespace SVG.Forms.Plugin.Abstractions
{
  public class SvgImage : Image
  {
    /// <summary>
    /// The path to the svg file
    /// </summary>
    public static readonly BindableProperty SvgPathProperty =
      BindableProperty.Create("SvgPath", typeof(string), typeof(SvgImage), default(string));

    /// <summary>
    /// The path to the svg file
    /// </summary>
    public string SvgPath
    {
      get { return (string)GetValue(SvgPathProperty); }
      set { SetValue(SvgPathProperty, value); }
    }

	/// <summary>
		/// The SVG as a string
	/// </summary>
	public static readonly BindableProperty SvgStringProperty =
		BindableProperty.Create("SvgString", typeof(string), typeof(SvgImage), default(string));

	/// <summary>
	/// The SVG as a string
	/// </summary>
	public string SvgString
	{
		get { return (string)GetValue(SvgStringProperty); }
		set { SetValue(SvgStringProperty, value); }
	}

    /// <summary>
    /// The assembly containing the svg file
    /// </summary>
    public static readonly BindableProperty SvgAssemblyProperty =
      BindableProperty.Create("SvgAssembly", typeof(Assembly), typeof(SvgImage), default(Assembly));

    /// <summary>
    /// The assembly containing the svg file
    /// </summary>
    public Assembly SvgAssembly
    {
      get { return (Assembly)GetValue(SvgAssemblyProperty); }
      set { SetValue(SvgAssemblyProperty, value); }
    }
  }
}