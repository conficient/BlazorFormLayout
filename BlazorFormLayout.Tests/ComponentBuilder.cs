using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFormLayout.Tests
{
    /// <summary>
    /// Build component with parameters
    /// </summary>
    /// <typeparam name="TComponent"></typeparam>
    public class ComponentBuilder<TComponent> where TComponent: ComponentBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        public ComponentBuilder()
        {
        }

        private readonly ParameterBuilder paramBuilder = new ParameterBuilder();

        /// <summary>
        /// Add parameter (fluent)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public ComponentBuilder<TComponent> AddParameter(string name, object value) 
        {
            paramBuilder.Add(name, value);
            return this;
        }

        public ComponentBuilder<TComponent> AddRenderFragment<TChildType>(string name, ParameterView parameters) where TChildType : ComponentBase
        {
            RenderFragment rf = builder =>
            {
                builder.OpenComponent<TChildType>(0);
                builder.CloseComponent();
            };
            paramBuilder.Add(name, rf);
            return this;
        }

        /// <summary>
        /// Render component
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public RenderedComponent<TComponent> Render(TestHost host)
        {
            if (host== null) throw new ArgumentNullException(nameof(host));
            // create parameters
            var parameters = paramBuilder.ToParameterView();

            // create and return
            return host.AddComponent<TComponent>(parameters);
        }
        
    }
}
