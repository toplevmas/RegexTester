using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace RegexTester.My
{
	[StandardModule, HideModuleName, GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			public AboutBoxForm m_AboutBoxForm;
			public CompileForm m_CompileForm;
			public EscapeForm m_EscapeForm;
			public GenerateCodeForm m_GenerateCodeForm;
			public MainForm m_MainForm;
			public PropertiesForm m_PropertiesForm;
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
			public AboutBoxForm AboutBoxForm
			{
				get
				{
					this.m_AboutBoxForm = MyProject.MyForms.Create__Instance__<AboutBoxForm>(this.m_AboutBoxForm);
					return this.m_AboutBoxForm;
				}
				set
				{
					if (value != this.m_AboutBoxForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AboutBoxForm>(ref this.m_AboutBoxForm);
					}
				}
			}
			public CompileForm CompileForm
			{
				get
				{
					this.m_CompileForm = MyProject.MyForms.Create__Instance__<CompileForm>(this.m_CompileForm);
					return this.m_CompileForm;
				}
				set
				{
					if (value != this.m_CompileForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CompileForm>(ref this.m_CompileForm);
					}
				}
			}
			public EscapeForm EscapeForm
			{
				get
				{
					this.m_EscapeForm = MyProject.MyForms.Create__Instance__<EscapeForm>(this.m_EscapeForm);
					return this.m_EscapeForm;
				}
				set
				{
					if (value != this.m_EscapeForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EscapeForm>(ref this.m_EscapeForm);
					}
				}
			}
			public GenerateCodeForm GenerateCodeForm
			{
				get
				{
					this.m_GenerateCodeForm = MyProject.MyForms.Create__Instance__<GenerateCodeForm>(this.m_GenerateCodeForm);
					return this.m_GenerateCodeForm;
				}
				set
				{
					if (value != this.m_GenerateCodeForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<GenerateCodeForm>(ref this.m_GenerateCodeForm);
					}
				}
			}
			public MainForm MainForm
			{
				get
				{
					this.m_MainForm = MyProject.MyForms.Create__Instance__<MainForm>(this.m_MainForm);
					return this.m_MainForm;
				}
				set
				{
					if (value != this.m_MainForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MainForm>(ref this.m_MainForm);
					}
				}
			}
			public PropertiesForm PropertiesForm
			{
				get
				{
					this.m_PropertiesForm = MyProject.MyForms.Create__Instance__<PropertiesForm>(this.m_PropertiesForm);
					return this.m_PropertiesForm;
				}
				set
				{
					if (value != this.m_PropertiesForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PropertiesForm>(ref this.m_PropertiesForm);
					}
				}
			}
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				T result;
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
                        try
                        {
                            result = Activator.CreateInstance<T>();
                            return result;
                        }
                        catch (Exception arg_78_0)
                        {
                            //object arg_78_0;
                            TargetInvocationException expr_7D = arg_78_0 as TargetInvocationException;
                            int arg_9A_0;
                            if (expr_7D == null)
                            {
                                arg_9A_0 = 0;
                            }
                            else
                            {
                                TargetInvocationException ex = expr_7D;
                                ProjectData.SetProjectError(expr_7D);
                                arg_9A_0 = (((ex.InnerException != null) ) ? 1 : 0);
                            }
                            //endfilter(arg_9A_0);
                        }
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				result = Instance;
				return result;
			}
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public MyForms()
			{
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public MyWebServices()
			{
			}
		}
		[EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated, ThreadStatic]
			private static T m_ThreadStaticValue;
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}
			[EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}
		}
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
