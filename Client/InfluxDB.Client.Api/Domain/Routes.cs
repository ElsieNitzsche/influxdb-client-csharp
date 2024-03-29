/* 
 * InfluxDB OSS API Service
 *
 * The InfluxDB v2 API provides a programmatic interface for all interactions with InfluxDB. Access the InfluxDB API using the `/api/v2/` endpoint. 
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Routes
    /// </summary>
    [DataContract]
    public partial class Routes : IEquatable<Routes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Routes" /> class.
        /// </summary>
        /// <param name="authorizations">authorizations.</param>
        /// <param name="buckets">buckets.</param>
        /// <param name="dashboards">dashboards.</param>
        /// <param name="external">external.</param>
        /// <param name="variables">variables.</param>
        /// <param name="me">me.</param>
        /// <param name="flags">flags.</param>
        /// <param name="orgs">orgs.</param>
        /// <param name="query">query.</param>
        /// <param name="setup">setup.</param>
        /// <param name="signin">signin.</param>
        /// <param name="signout">signout.</param>
        /// <param name="sources">sources.</param>
        /// <param name="system">system.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="telegrafs">telegrafs.</param>
        /// <param name="users">users.</param>
        /// <param name="write">write.</param>
        public Routes(string authorizations = default, string buckets = default, string dashboards = default,
            RoutesExternal external = default, string variables = default, string me = default, string flags = default,
            string orgs = default, RoutesQuery query = default, string setup = default, string signin = default,
            string signout = default, string sources = default, RoutesSystem system = default, string tasks = default,
            string telegrafs = default, string users = default, string write = default)
        {
            Authorizations = authorizations;
            Buckets = buckets;
            Dashboards = dashboards;
            External = external;
            Variables = variables;
            Me = me;
            Flags = flags;
            Orgs = orgs;
            Query = query;
            Setup = setup;
            Signin = signin;
            Signout = signout;
            Sources = sources;
            System = system;
            Tasks = tasks;
            Telegrafs = telegrafs;
            Users = users;
            Write = write;
        }

        /// <summary>
        /// Gets or Sets Authorizations
        /// </summary>
        [DataMember(Name = "authorizations", EmitDefaultValue = false)]
        public string Authorizations { get; set; }

        /// <summary>
        /// Gets or Sets Buckets
        /// </summary>
        [DataMember(Name = "buckets", EmitDefaultValue = false)]
        public string Buckets { get; set; }

        /// <summary>
        /// Gets or Sets Dashboards
        /// </summary>
        [DataMember(Name = "dashboards", EmitDefaultValue = false)]
        public string Dashboards { get; set; }

        /// <summary>
        /// Gets or Sets External
        /// </summary>
        [DataMember(Name = "external", EmitDefaultValue = false)]
        public RoutesExternal External { get; set; }

        /// <summary>
        /// Gets or Sets Variables
        /// </summary>
        [DataMember(Name = "variables", EmitDefaultValue = false)]
        public string Variables { get; set; }

        /// <summary>
        /// Gets or Sets Me
        /// </summary>
        [DataMember(Name = "me", EmitDefaultValue = false)]
        public string Me { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public string Flags { get; set; }

        /// <summary>
        /// Gets or Sets Orgs
        /// </summary>
        [DataMember(Name = "orgs", EmitDefaultValue = false)]
        public string Orgs { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public RoutesQuery Query { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name = "setup", EmitDefaultValue = false)]
        public string Setup { get; set; }

        /// <summary>
        /// Gets or Sets Signin
        /// </summary>
        [DataMember(Name = "signin", EmitDefaultValue = false)]
        public string Signin { get; set; }

        /// <summary>
        /// Gets or Sets Signout
        /// </summary>
        [DataMember(Name = "signout", EmitDefaultValue = false)]
        public string Signout { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name = "sources", EmitDefaultValue = false)]
        public string Sources { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name = "system", EmitDefaultValue = false)]
        public RoutesSystem System { get; set; }

        /// <summary>
        /// Gets or Sets Tasks
        /// </summary>
        [DataMember(Name = "tasks", EmitDefaultValue = false)]
        public string Tasks { get; set; }

        /// <summary>
        /// Gets or Sets Telegrafs
        /// </summary>
        [DataMember(Name = "telegrafs", EmitDefaultValue = false)]
        public string Telegrafs { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name = "users", EmitDefaultValue = false)]
        public string Users { get; set; }

        /// <summary>
        /// Gets or Sets Write
        /// </summary>
        [DataMember(Name = "write", EmitDefaultValue = false)]
        public string Write { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Routes {\n");
            sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
            sb.Append("  Dashboards: ").Append(Dashboards).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  Me: ").Append(Me).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Orgs: ").Append(Orgs).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Signin: ").Append(Signin).Append("\n");
            sb.Append("  Signout: ").Append(Signout).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Telegrafs: ").Append(Telegrafs).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Write: ").Append(Write).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Routes);
        }

        /// <summary>
        /// Returns true if Routes instances are equal
        /// </summary>
        /// <param name="input">Instance of Routes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Routes input)
        {
            if (input == null)
            {
                return false;
            }

            return
                (
                    Authorizations == input.Authorizations ||
                    Authorizations != null && Authorizations.Equals(input.Authorizations)
                ) &&
                (
                    Buckets == input.Buckets ||
                    Buckets != null && Buckets.Equals(input.Buckets)
                ) &&
                (
                    Dashboards == input.Dashboards ||
                    Dashboards != null && Dashboards.Equals(input.Dashboards)
                ) && External != null && External.Equals(input.External) && (
                    Variables == input.Variables ||
                    Variables != null && Variables.Equals(input.Variables)
                ) && (
                    Me == input.Me ||
                    Me != null && Me.Equals(input.Me)
                ) && (
                    Flags == input.Flags ||
                    Flags != null && Flags.Equals(input.Flags)
                ) && (
                    Orgs == input.Orgs ||
                    Orgs != null && Orgs.Equals(input.Orgs)
                ) && Query != null && Query.Equals(input.Query) && (
                    Setup == input.Setup ||
                    Setup != null && Setup.Equals(input.Setup)
                ) && (
                    Signin == input.Signin ||
                    Signin != null && Signin.Equals(input.Signin)
                ) && (
                    Signout == input.Signout ||
                    Signout != null && Signout.Equals(input.Signout)
                ) && (
                    Sources == input.Sources ||
                    Sources != null && Sources.Equals(input.Sources)
                ) && System != null && System.Equals(input.System) && (
                    Tasks == input.Tasks ||
                    Tasks != null && Tasks.Equals(input.Tasks)
                ) && (
                    Telegrafs == input.Telegrafs ||
                    Telegrafs != null && Telegrafs.Equals(input.Telegrafs)
                ) && (
                    Users == input.Users ||
                    Users != null && Users.Equals(input.Users)
                ) && (
                    Write == input.Write ||
                    Write != null && Write.Equals(input.Write)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;

                if (Authorizations != null)
                {
                    hashCode = hashCode * 59 + Authorizations.GetHashCode();
                }

                if (Buckets != null)
                {
                    hashCode = hashCode * 59 + Buckets.GetHashCode();
                }

                if (Dashboards != null)
                {
                    hashCode = hashCode * 59 + Dashboards.GetHashCode();
                }

                if (External != null)
                {
                    hashCode = hashCode * 59 + External.GetHashCode();
                }

                if (Variables != null)
                {
                    hashCode = hashCode * 59 + Variables.GetHashCode();
                }

                if (Me != null)
                {
                    hashCode = hashCode * 59 + Me.GetHashCode();
                }

                if (Flags != null)
                {
                    hashCode = hashCode * 59 + Flags.GetHashCode();
                }

                if (Orgs != null)
                {
                    hashCode = hashCode * 59 + Orgs.GetHashCode();
                }

                if (Query != null)
                {
                    hashCode = hashCode * 59 + Query.GetHashCode();
                }

                if (Setup != null)
                {
                    hashCode = hashCode * 59 + Setup.GetHashCode();
                }

                if (Signin != null)
                {
                    hashCode = hashCode * 59 + Signin.GetHashCode();
                }

                if (Signout != null)
                {
                    hashCode = hashCode * 59 + Signout.GetHashCode();
                }

                if (Sources != null)
                {
                    hashCode = hashCode * 59 + Sources.GetHashCode();
                }

                if (System != null)
                {
                    hashCode = hashCode * 59 + System.GetHashCode();
                }

                if (Tasks != null)
                {
                    hashCode = hashCode * 59 + Tasks.GetHashCode();
                }

                if (Telegrafs != null)
                {
                    hashCode = hashCode * 59 + Telegrafs.GetHashCode();
                }

                if (Users != null)
                {
                    hashCode = hashCode * 59 + Users.GetHashCode();
                }

                if (Write != null)
                {
                    hashCode = hashCode * 59 + Write.GetHashCode();
                }

                return hashCode;
            }
        }
    }
}