//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.0.0+d713b38
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, ICertificates, IContactSection, IFooterProperties, IHeaderAbout, INavTitle, IPortfolioPlace
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About Certificates
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("AboutCertificates")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutCertificates => global::Umbraco.Cms.Web.Common.PublishedModels.Certificates.GetAboutCertificates(this, _publishedValueFallback);

		///<summary>
		/// About Education
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutEducation")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString AboutEducation => global::Umbraco.Cms.Web.Common.PublishedModels.Certificates.GetAboutEducation(this, _publishedValueFallback);

		///<summary>
		/// Button Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("buttonTitle")]
		public virtual string ButtonTitle => global::Umbraco.Cms.Web.Common.PublishedModels.Certificates.GetButtonTitle(this, _publishedValueFallback);

		///<summary>
		/// Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("link")]
		public virtual global::Umbraco.Cms.Core.Models.Link Link => global::Umbraco.Cms.Web.Common.PublishedModels.Certificates.GetLink(this, _publishedValueFallback);

		///<summary>
		/// Main Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainTitle")]
		public virtual string MainTitle => global::Umbraco.Cms.Web.Common.PublishedModels.Certificates.GetMainTitle(this, _publishedValueFallback);

		///<summary>
		/// Contact Info: Contact Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInfo")]
		public virtual string ContactInfo => global::Umbraco.Cms.Web.Common.PublishedModels.ContactSection.GetContactInfo(this, _publishedValueFallback);

		///<summary>
		/// Footer Social Links: Enter Social Lins to display in the footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerSocialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.SocialLink> FooterSocialLinks => global::Umbraco.Cms.Web.Common.PublishedModels.FooterProperties.GetFooterSocialLinks(this, _publishedValueFallback);

		///<summary>
		/// Icon Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("iconTitle")]
		public virtual string IconTitle => global::Umbraco.Cms.Web.Common.PublishedModels.FooterProperties.GetIconTitle(this, _publishedValueFallback);

		///<summary>
		/// Location Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("locationSubtitle")]
		public virtual string LocationSubtitle => global::Umbraco.Cms.Web.Common.PublishedModels.FooterProperties.GetLocationSubtitle(this, _publishedValueFallback);

		///<summary>
		/// Location Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("locationTitle")]
		public virtual string LocationTitle => global::Umbraco.Cms.Web.Common.PublishedModels.FooterProperties.GetLocationTitle(this, _publishedValueFallback);

		///<summary>
		/// Owner Photo: Photo of the portfolio owner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("OwnerPhoto")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OwnerPhoto => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderAbout.GetOwnerPhoto(this, _publishedValueFallback);

		///<summary>
		/// Sub Title: Description of profession
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("SubTitle")]
		public virtual string SubTitle => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderAbout.GetSubTitle(this, _publishedValueFallback);

		///<summary>
		/// Title Name: A site about who owns the portfolio
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleName")]
		public virtual string TitleName => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderAbout.GetTitleName(this, _publishedValueFallback);

		///<summary>
		/// Title1: Navigation Headings
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("Title1")]
		public virtual string Title1 => global::Umbraco.Cms.Web.Common.PublishedModels.NavTitle.GetTitle1(this, _publishedValueFallback);

		///<summary>
		/// Title2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title2")]
		public virtual string Title2 => global::Umbraco.Cms.Web.Common.PublishedModels.NavTitle.GetTitle2(this, _publishedValueFallback);

		///<summary>
		/// Title3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title3")]
		public virtual string Title3 => global::Umbraco.Cms.Web.Common.PublishedModels.NavTitle.GetTitle3(this, _publishedValueFallback);

		///<summary>
		/// All Language
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("allLenguage")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> AllLenguage => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetAllLenguage(this, _publishedValueFallback);

		///<summary>
		/// Description1: knowledge and experience
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description1")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description1 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription1(this, _publishedValueFallback);

		///<summary>
		/// Description2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description2")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description2 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription2(this, _publishedValueFallback);

		///<summary>
		/// Description3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description3")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description3 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription3(this, _publishedValueFallback);

		///<summary>
		/// Description4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description4")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description4 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription4(this, _publishedValueFallback);

		///<summary>
		/// Description5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description5")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description5 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription5(this, _publishedValueFallback);

		///<summary>
		/// Description6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description6")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description6 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetDescription6(this, _publishedValueFallback);

		///<summary>
		/// Language photo1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto1")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto1 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto1(this, _publishedValueFallback);

		///<summary>
		/// Language  photo2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto2 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto2(this, _publishedValueFallback);

		///<summary>
		/// Language  photo3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto3")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto3 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto3(this, _publishedValueFallback);

		///<summary>
		/// Language  photo4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto4")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto4 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto4(this, _publishedValueFallback);

		///<summary>
		/// Language  photo5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto5")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto5 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto5(this, _publishedValueFallback);

		///<summary>
		/// Language  photo6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.0.0+d713b38")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("languagePhoto6")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LanguagePhoto6 => global::Umbraco.Cms.Web.Common.PublishedModels.PortfolioPlace.GetLanguagePhoto6(this, _publishedValueFallback);
	}
}