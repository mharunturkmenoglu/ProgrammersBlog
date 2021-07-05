#pragma checksum "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d21236844e094f61dea29b8735f0505362f2ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d21236844e094f61dea29b8735f0505362f2ee", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Entities.Dtos.CategoryListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card mb-4 mt-2"">
        <div class=""card-header"">
            <i class=""fas fa-table mr-1""></i>
            Kategoriler
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Kategori Adi</th>
                            <th>Aciklamasi</th>
                            <th>Aktif Mi?</th>
                            <th>Silinmis Mi? date</th>
                            <th>Not</th>
                            <th>Olustutulma Tarihi</th>
                            <th>Olusturan Kullanici</th>
                            <th>Son Duzenleneme Tarihi</th>
                            <th>Son Duzenleyen Kullanici Adi</th>
                        </tr>
                    </thead>
                    <tfoot>
       ");
            WriteLiteral(@"                 <tr>
                            <th>ID</th>
                            <th>Adi</th>
                            <th>Aciklamasi</th>
                            <th>Aktif Mi?</th>
                            <th>Silinmis Mi?</th>
                            <th>Not</th>
                            <th>Olustutulma Tarihi</th>
                            <th>Olusturan Kullanici Adi</th>
                            <th>Son Duzenleneme Tarihi</th>
                            <th>Son Duzenleyen Kullanici Adi</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 46 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 49 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 60 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 66 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 70 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Dashboard sayfasina geri donmek icin lutfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d21236844e094f61dea29b8735f0505362f2ee10981", async() => {
                WriteLiteral("tiklayiniz.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 73 "C:\source\ProgrammersBlog\ProgrammersBlog.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#categoriesTable').DataTable({
                dom:
                    ""<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>"" +
                    ""<'row'<'col-sm-12'tr>>"" +
                    ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                buttons: [
                    {
                        text: 'Ekle',
                        className: 'btn btn-success',
                        action: function (e, dt, node, config) {
                            alert('Ekle Butonuna Basildi');
                        }
                    },
                    {
                        text: 'Yenile',
                        className: 'btn btn-warning',
                        action: function (e, dt, node, config) {
                            alert('Yenile Butonuna Basildi');
                        }
                    }
                ],
                language: {
                    ""emptyTable"": ""Tab");
                WriteLiteral(@"loda herhangi bir veri mevcut değil"",
                    ""info"": ""_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor"",
                    ""infoEmpty"": ""Kayıt yok"",
                    ""infoFiltered"": ""(_MAX_ kayıt içerisinden bulunan)"",
                    ""infoThousands"": ""."",
                    ""lengthMenu"": ""Sayfada _MENU_ kayıt göster"",
                    ""loadingRecords"": ""Yükleniyor..."",
                    ""processing"": ""İşleniyor..."",
                    ""search"": ""Ara:"",
                    ""zeroRecords"": ""Eşleşen kayıt bulunamadı"",
                    ""paginate"": {
                        ""first"": ""İlk"",
                        ""last"": ""Son"",
                        ""next"": ""Sonraki"",
                        ""previous"": ""Önceki""
                    },
                    ""aria"": {
                        ""sortAscending"": "": artan sütun sıralamasını aktifleştir"",
                        ""sortDescending"": "": azalan sütun sıralamasını aktifleştir""
                 ");
                WriteLiteral(@"   },
                    ""select"": {
                        ""rows"": {
                            ""_"": ""%d kayıt seçildi"",
                            ""1"": ""1 kayıt seçildi"",
                            ""0"": ""-""
                        },
                        ""0"": ""-"",
                        ""1"": ""%d satır seçildi"",
                        ""2"": ""-"",
                        ""_"": ""%d satır seçildi"",
                        ""cells"": {
                            ""1"": ""1 hücre seçildi"",
                            ""_"": ""%d hücre seçildi""
                        },
                        ""columns"": {
                            ""1"": ""1 sütun seçildi"",
                            ""_"": ""%d sütun seçildi""
                        }
                    },
                    ""autoFill"": {
                        ""cancel"": ""İptal"",
                        ""fillHorizontal"": ""Hücreleri yatay olarak doldur"",
                        ""fillVertical"": ""Hücreleri dikey olarak doldur"",
            ");
                WriteLiteral(@"            ""info"": ""-"",
                        ""fill"": ""Bütün hücreleri <i>%d<\/i> ile doldur""
                    },
                    ""buttons"": {
                        ""collection"": ""Koleksiyon <span class=\""ui-button-icon-primary ui-icon ui-icon-triangle-1-s\""><\/span>"",
                        ""colvis"": ""Sütun görünürlüğü"",
                        ""colvisRestore"": ""Görünürlüğü eski haline getir"",
                        ""copySuccess"": {
                            ""1"": ""1 satır panoya kopyalandı"",
                            ""_"": ""%ds satır panoya kopyalandı""
                        },
                        ""copyTitle"": ""Panoya kopyala"",
                        ""csv"": ""CSV"",
                        ""excel"": ""Excel"",
                        ""pageLength"": {
                            ""-1"": ""Bütün satırları göster"",
                            ""1"": ""-"",
                            ""_"": ""%d satır göster""
                        },
                        ""pdf"": ""PDF"",
           ");
                WriteLiteral(@"             ""print"": ""Yazdır"",
                        ""copy"": ""Kopyala"",
                        ""copyKeys"": ""Tablodaki veriyi kopyalamak için CTRL veya u2318 + C tuşlarına basınız. İptal etmek için bu mesaja tıklayın veya escape tuşuna basın.""
                    },
                    ""infoPostFix"": ""-"",
                    ""searchBuilder"": {
                        ""add"": ""Koşul Ekle"",
                        ""button"": {
                            ""0"": ""Arama Oluşturucu"",
                            ""_"": ""Arama Oluşturucu (%d)""
                        },
                        ""condition"": ""Koşul"",
                        ""conditions"": {
                            ""date"": {
                                ""after"": ""Sonra"",
                                ""before"": ""Önce"",
                                ""between"": ""Arasında"",
                                ""empty"": ""Boş"",
                                ""equals"": ""Eşittir"",
                                ""not"": ""Değildir"",
      ");
                WriteLiteral(@"                          ""notBetween"": ""Dışında"",
                                ""notEmpty"": ""Dolu""
                            },
                            ""number"": {
                                ""between"": ""Arasında"",
                                ""empty"": ""Boş"",
                                ""equals"": ""Eşittir"",
                                ""gt"": ""Büyüktür"",
                                ""gte"": ""Büyük eşittir"",
                                ""lt"": ""Küçüktür"",
                                ""lte"": ""Küçük eşittir"",
                                ""not"": ""Değildir"",
                                ""notBetween"": ""Dışında"",
                                ""notEmpty"": ""Dolu""
                            },
                            ""string"": {
                                ""contains"": ""İçerir"",
                                ""empty"": ""Boş"",
                                ""endsWith"": ""İle biter"",
                                ""equals"": ""Eşittir"",
                     ");
                WriteLiteral(@"           ""not"": ""Değildir"",
                                ""notEmpty"": ""Dolu"",
                                ""startsWith"": ""İle başlar""
                            },
                            ""array"": {
                                ""contains"": ""İçerir"",
                                ""empty"": ""Boş"",
                                ""equals"": ""Eşittir"",
                                ""not"": ""Değildir"",
                                ""notEmpty"": ""Dolu"",
                                ""without"": ""Hariç""
                            }
                        },
                        ""data"": ""Veri"",
                        ""deleteTitle"": ""Filtreleme kuralını silin"",
                        ""leftTitle"": ""Kriteri dışarı çıkart"",
                        ""logicAnd"": ""ve"",
                        ""logicOr"": ""veya"",
                        ""rightTitle"": ""Kriteri içeri al"",
                        ""title"": {
                            ""0"": ""Arama Oluşturucu"",
                         ");
                WriteLiteral(@"   ""_"": ""Arama Oluşturucu (%d)""
                        },
                        ""value"": ""Değer"",
                        ""clearAll"": ""Filtreleri Temizle""
                    },
                    ""searchPanes"": {
                        ""clearMessage"": ""Hepsini Temizle"",
                        ""collapse"": {
                            ""0"": ""Arama Bölmesi"",
                            ""_"": ""Arama Bölmesi (%d)""
                        },
                        ""count"": ""{total}"",
                        ""countFiltered"": ""{shown}\/{total}"",
                        ""emptyPanes"": ""Arama Bölmesi yok"",
                        ""loadMessage"": ""Arama Bölmeleri yükleniyor ..."",
                        ""title"": ""Etkin filtreler - %d""
                    },
                    ""searchPlaceholder"": ""Ara"",
                    ""thousands"": ""."",
                    ""datetime"": {
                        ""amPm"": [
                            ""öö"",
                            ""ös""
                  ");
                WriteLiteral(@"      ],
                        ""hours"": ""Saat"",
                        ""minutes"": ""Dakika"",
                        ""next"": ""Sonraki"",
                        ""previous"": ""Önceki"",
                        ""seconds"": ""Saniye"",
                        ""unknown"": ""Bilinmeyen""
                    },
                    ""decimal"": "","",
                    ""editor"": {
                        ""close"": ""Kapat"",
                        ""create"": {
                            ""button"": ""Yeni"",
                            ""submit"": ""Kaydet"",
                            ""title"": ""Yeni kayıt oluştur""
                        },
                        ""edit"": {
                            ""button"": ""Düzenle"",
                            ""submit"": ""Güncelle"",
                            ""title"": ""Kaydı düzenle""
                        },
                        ""error"": {
                            ""system"": ""Bir sistem hatası oluştu (Ayrıntılı bilgi)""
                        },
                 ");
                WriteLiteral(@"       ""multi"": {
                            ""info"": ""Seçili kayıtlar bu alanda farklı değerler içeriyor. Seçili kayıtların hepsinde bu alana aynı değeri atamak için buraya tıklayın; aksi halde her kayıt bu alanda kendi değerini koruyacak."",
                            ""noMulti"": ""Bu alan bir grup olarak değil ancak tekil olarak düzenlenebilir."",
                            ""restore"": ""Değişiklikleri geri al"",
                            ""title"": ""Çoklu değer""
                        },
                        ""remove"": {
                            ""button"": ""Sil"",
                            ""confirm"": {
                                ""_"": ""%d adet kaydı silmek istediğinize emin misiniz?"",
                                ""1"": ""Bu kaydı silmek istediğinizden emin misiniz?""
                            },
                            ""submit"": ""Sil"",
                            ""title"": ""Kayıtları sil""
                        }
                    }
                }
            });
        ");
                WriteLiteral("});\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Entities.Dtos.CategoryListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591