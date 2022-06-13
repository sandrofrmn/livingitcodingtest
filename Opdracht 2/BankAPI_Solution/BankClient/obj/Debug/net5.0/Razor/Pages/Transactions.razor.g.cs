#pragma checksum "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fb352e8490a226a9a878181390ce095e439fcb7"
// <auto-generated/>
#pragma warning disable 1591
namespace BankClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using BankClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using BankClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using BankClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\_Imports.razor"
using BankLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class Transactions : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Transactions</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "EditContext", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 5 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                       editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddMarkupContent(5, "<label for=\"AccountNumber\">Account Number</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "AccountNumber");
                __builder2.AddAttribute(8, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                                   transactionModel.AccountNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => transactionModel.AccountNumber = __value, transactionModel.AccountNumber))));
                __builder2.AddAttribute(10, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => transactionModel.AccountNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateValidationMessage_0(__builder2, 12, 13, 
#nullable restore
#line 9 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                () => transactionModel.AccountNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddMarkupContent(16, "<label for=\"StartBalance\">Start Balance</label>\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateInputNumber_1(__builder2, 17, 18, "StartBalance", 19, 
#nullable restore
#line 13 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                                    transactionModel.StartBalance

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => transactionModel.StartBalance = __value, transactionModel.StartBalance)), 21, () => transactionModel.StartBalance);
                __builder2.AddMarkupContent(22, "\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateValidationMessage_2(__builder2, 23, 24, 
#nullable restore
#line 14 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                () => transactionModel.StartBalance

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddMarkupContent(27, "<label for=\"AccountNumber\">Mutation</label>\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateInputNumber_3(__builder2, 28, 29, "Mutation", 30, 
#nullable restore
#line 18 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                                transactionModel.Mutation

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => transactionModel.Mutation = __value, transactionModel.Mutation)), 32, () => transactionModel.Mutation);
                __builder2.AddMarkupContent(33, "\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateValidationMessage_4(__builder2, 34, 35, 
#nullable restore
#line 19 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                () => transactionModel.Mutation

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddMarkupContent(38, "<label for=\"Description\">Description</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "Description");
                __builder2.AddAttribute(41, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                                 transactionModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => transactionModel.Description = __value, transactionModel.Description))));
                __builder2.AddAttribute(43, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => transactionModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __Blazor.BankClient.Pages.Transactions.TypeInference.CreateValidationMessage_5(__builder2, 45, 46, 
#nullable restore
#line 24 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                                () => transactionModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
                  SubmitTransactionIfValid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Submit Transaction");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\imsan\source\repos\BankAPI_Solution\BankClient\Pages\Transactions.razor"
       
    private List<Transaction> transactions;
    private EditContext editContext;

    private TransactionModel transactionModel;

    //protected override Task OnInitializedAsync()
    //{
    //    try
    //    {
    //        editContext = new EditContext(transactionModel);
    //    }
    //    catch (Exception ex)
    //    {
    //        ex.Message.ToString();
    //    }
    //}

    private async Task SubmitTransactionIfValid()
    {
        if (editContext.Validate())
        {
            await SubmitTransaction();
        }
    }

    private async Task SubmitTransaction()
    {
        try
        {
            Transaction transaction = transactionModel.GetTransaction();
            //transaction = await Interactor.WriteTransaction(transaction);
        }
        catch (Exception ex)
        {
            ex.Message.ToString();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BankClient.Pages.Transactions
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591