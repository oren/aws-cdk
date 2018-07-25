using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.ServiceCatalog.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-portfolioshare.html </remarks>
    [JsiiClass(typeof(PortfolioShareResource), "@aws-cdk/aws-servicecatalog.cloudformation.PortfolioShareResource", "[{\"name\":\"parent\",\"type\":{\"fqn\":\"@aws-cdk/cdk.Construct\"}},{\"name\":\"name\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"properties\",\"type\":{\"fqn\":\"@aws-cdk/aws-servicecatalog.cloudformation.PortfolioShareResourceProps\"}}]")]
    public class PortfolioShareResource : Resource
    {
        public PortfolioShareResource(Construct parent, string name, IPortfolioShareResourceProps properties): base(new DeputyProps(new object[]{parent, name, properties}))
        {
        }

        protected PortfolioShareResource(ByRefValue reference): base(reference)
        {
        }

        protected PortfolioShareResource(DeputyProps props): base(props)
        {
        }

        /// <summary>The CloudFormation resource type name for this resource class.</summary>
        [JsiiProperty("resourceTypeName", "{\"primitive\":\"string\"}")]
        public static string ResourceTypeName
        {
            get;
        }

        = GetStaticProperty<string>(typeof(PortfolioShareResource));
        [JsiiMethod("renderProperties", "{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"primitive\":\"any\"}}}", "[]")]
        protected override IDictionary<string, object> RenderProperties()
        {
            return InvokeInstanceMethod<IDictionary<string, object>>(new object[]{});
        }
    }
}