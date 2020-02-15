﻿using DataAccess.Interfaces;
using DataAccess.Storing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MockRepositories
{

    public class MockPageRepository : IPageRepository
    {
        class Page
        {
            internal string HTML { get; set; }
            internal string MD { get; set; }
        }
        Dictionary<String, Dictionary<String, Page>> notADatabase;
        public MockPageRepository()
        {
            notADatabase = new Dictionary<string, Dictionary<string, Page>>
            {
                ["training-code"] = new Dictionary<string, Page>()
                {
                    ["readme"] = new Page()
                    {
                        MD = "# training-code\nThis repository will be used for sharing code, projects and notes\n\n## Environment Setup\n* [github](https://github.com)\n  *Create an account\n  * We will use this for version control, class examples, and submission of your assignments\n*[git for windows + git bash] (https://git-scm.com/downloads) \n     * installs linux-like bash environment(terminal)\n     * also installs git, for version control\n* [Slack] (https://slack.com)\n  * www.slack.com\n  * Create a slack account or join using the [magic link] (https://join.slack.com/t/revaturepro/shared_invite/enQtODcyNzMxNTAyOTAwLTI2ODI4ZTVhY2E4YTgwMjYzZDczNTkyNDVhZTJkZjExNjlkMGNlNTE3MDY3NzBiZjk5OGQxOTczZDE1MWM5Mzg).\n  * We will use this for communications between the group outside of work hours. \n\n### tools:\n  * [visual studio](https://visualstudio.microsoft.com/downloads/)\n     * atleast.net core workload required for week 1\n  * [visual studio code](https://code.visualstudio.com/download)\n  * [.net core sdk](https://dotnet.microsoft.com/download)\n     * lets us compile c# code.\n     * included with visual studio workload\n     * gives us \"dotnet\" command\n\n### [gitignore](https://github.com/dotnet/core/blob/master/.gitignore) \n\n### Useful Links\n*[Git Cheat Sheet](https://www.git-tower.com/blog/git-cheat-sheet)\n* [Git Basics](https://youtu.be/0fKg7e37bQE)\n* [Git Team Basics](https://youtu.be/oFYyTZwMyAg)\n\n*The most common laptops are Windows PCs.Where MacOS and Linux systems can use package managers, Windows prefers its own GUI wizards.*\n\n\n* [Hacker Rank](https://www.hackerrank.com/)\n  * Good source of practice. Use it often for practice.Of course, if you still have assigned work to do, that work takes precedence.\n* [learn about md files](https://guides.github.com/features/mastering-markdown/)\n  * it's always good to read and manage markdowns.\n  * Also[markdown cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet#headers)\\n",
                        HTML = "<h1>\n	<a id=\"user-content-training-code\" class=\"anchor\" href=\"#training-code\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>training-code</h1>\n<p>This repository will be used for sharing code, projects and notes</p>\n<h2>\n	<a id=\"user-content-environment-setup\" class=\"anchor\" href=\"#environment-setup\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>Environment Setup</h2>\n<ul>\n	<li>\n		<a href=\"https://github.com\">github</a>\n		<ul>\n			<li>Create an account</li>\n			<li>We will use this for version control, class examples, and submission of your assignments</li>\n		</ul>\n	</li>\n	<li>\n		<a href=\"https://git-scm.com/downloads\" rel=\"nofollow\">git for windows + git bash</a>\n		<ul>\n			<li>installs linux-like bash environment (terminal)</li>\n			<li>also installs git, for version control</li>\n		</ul>\n	</li>\n	<li>\n		<a href=\"https://slack.com\" rel=\"nofollow\">Slack</a>\n		<ul>\n			<li><a href=\"http://www.slack.com\" rel=\"nofollow\">www.slack.com</a></li>\n			<li>Create a slack account or join using the <a\n					href=\"https://join.slack.com/t/revaturepro/shared_invite/enQtODcyNzMxNTAyOTAwLTI2ODI4ZTVhY2E4YTgwMjYzZDczNTkyNDVhZTJkZjExNjlkMGNlNTE3MDY3NzBiZjk5OGQxOTczZDE1MWM5Mzg\"\n					rel=\"nofollow\">magic link</a>.</li>\n			<li>We will use this for communications between the group outside of work hours.</li>\n		</ul>\n	</li>\n</ul>\n<h3>\n	<a id=\"user-content-tools\" class=\"anchor\" href=\"#tools\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>tools:</h3>\n<ul>\n	<li>\n		<a href=\"https://visualstudio.microsoft.com/downloads/\" rel=\"nofollow\">visual studio</a>\n		<ul>\n			<li>atleast .net core workload required for week 1</li>\n		</ul>\n	</li>\n	<li><a href=\"https://code.visualstudio.com/download\" rel=\"nofollow\">visual studio code</a></li>\n	<li>\n		<a href=\"https://dotnet.microsoft.com/download\" rel=\"nofollow\">.net core sdk</a>\n		<ul>\n			<li>lets us compile c# code.</li>\n			<li>included with visual studio workload</li>\n			<li>gives us \"dotnet\" command</li>\n		</ul>\n	</li>\n</ul>\n<h3>\n	<a id=\"user-content-gitignore\" class=\"anchor\" href=\"#gitignore\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a><a\n		href=\"https://github.com/dotnet/core/blob/master/.gitignore\">gitignore</a>\n</h3>\n<h3>\n	<a id=\"user-content-useful-links\" class=\"anchor\" href=\"#useful-links\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>Useful Links</h3>\n<ul>\n	<li><a href=\"https://www.git-tower.com/blog/git-cheat-sheet\" rel=\"nofollow\">Git Cheat Sheet</a></li>\n	<li><a href=\"https://youtu.be/0fKg7e37bQE\" rel=\"nofollow\">Git Basics</a></li>\n	<li><a href=\"https://youtu.be/oFYyTZwMyAg\" rel=\"nofollow\">Git Team Basics</a></li>\n</ul>\n<p><em>The most common laptops are Windows PCs. Where MacOS and Linux systems can use package managers, Windows prefers its own GUI wizards.</em>\n</p>\n<ul>\n	<li>\n		<a href=\"https://www.hackerrank.com/\" rel=\"nofollow\">Hacker Rank</a>\n		<ul>\n			<li>Good source of practice. Use it often for practice. Of course, if you still have assigned work to do,\n				that work takes precedence.</li>\n		</ul>\n	</li>\n	<li>\n		<a href=\"https://guides.github.com/features/mastering-markdown/\">learn about md files</a>\n		<ul>\n			<li>it's always good to read and manage markdowns.</li>\n			<li>Also <a href=\"https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet#headers\">markdown\n					cheatsheet</a>\n			</li>\n		</ul>\n	</li>\n</ul>"
                    },
                    ["efcoresteps"] = new Page()
                    {
                        MD = "# Entity Framework Core Steps:\n\n## Package Manager Console (for VS2019 users)\n- Run following commands in your Data Layer project in the VS2019 PMC (in your Tools menu option->Nuget Package Manager -> Package Manager Console)\n- `Install-Package Microsoft.EntityFrameworkCore.SqlServer`\n- `Install-Package Microsoft.EntityFrameworkCore.Tools`\n- `Install-Package Microsoft.EntityFrameworkCore.Design`\n- Build the project before Scaffolding\n- `Get-Help about_EntityFrameworkCore` - See the EF help commands\n- `Scaffold-DbContext -connection \"Server=<DB Server Name>;Database=<DB Name>;user id=<username>;Password=<password>;\" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - Its is mandatory to provide connectio string and the provider rest parameters are optional\n\n## .NET core CLI COMMANDS (specially VSCODE users)\n- Run following commands in your Data Layer project in the vscode terminal/gitbash/Command prompt)\n- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`\n- `dotnet add package Microsoft.EntityFrameworkCore.Design`\n- `dotnet add package Microsoft.EntityFrameworkCore.Tool`\n- `dotnet ef` - to check EF is installed\n- `dotnet ef -h` -See the EF help commands\n- `dotnet ef dbcontext scaffold -h` - see if help about EF Db Context Scaffold commands\n- `dotnet ef dbcontext scaffold -connection \"Server=<server name>;Database=<Db Name>;user id=<username>;Password=<password>;\" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir <Output Directory name> -context <context name>` - to get all Entities mapped from database objects to C# classes.\n\n\n[Reference](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)\n\n\n## To move the connection string from generated dbcontext file to JSON configuration file:\n1. add package `Microsoft.Extensions.Configuration.Json` to the console app. (turns out the other two packages from before are dependencies that are automatically added)\n2. add new item to console app project, type \"JSON File\", named \"appsettings.json\", with these contents:\n\n```\n{\n  \"ConnectionStrings\": {\n    \"<name you give to this data source>\": \"<your connection string>\"\n  }\n}\n```\n3. right-click on \"appsettings.json\" in the solution explorer, go to Properties, change \"Copy to Output Directory\" to \"Copy if newer\".\n4. make a \".gitignore\" file in your solution directory, with the contents \"appsettings.json\".\n5. in `Program.Main` of your console app, add the code:\n\n```\nvar configBuilder = new ConfigurationBuilder()\n    .SetBasePath(Directory.GetCurrentDirectory())\n    .AddJsonFile(\"appsettings.json\", optional: true, reloadOnChange: true);\nIConfigurationRoot configuration = configBuilder.Build();\n```\n6. to get the options ready to make a dbcontext, use the code (substituting the right stuff):\n```\nvar optionsBuilder = new DbContextOptionsBuilder<YourAppDbContext>();\noptionsBuilder.UseSqlServer(configuration.GetConnectionString(\"<name you gave to the data source>\"));\nvar options = optionsBuilder.Options;\n```\n7. then, when you need to make a dbcontext (to give you to your repository classes): `new YourAppDbContext(options)`.\n",
                        HTML = "<h1>\n	<a id=\"user-content-entity-framework-core-steps\" class=\"anchor\" href=\"#entity-framework-core-steps\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>Entity Framework Core Steps:\n</h1>\n<h2>\n	<a id=\"user-content-package-manager-console-for-vs2019-users\" class=\"anchor\"\n		href=\"#package-manager-console-for-vs2019-users\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>Package Manager Console (for\n	VS2019 users)</h2>\n<ul>\n	<li>Run following commands in your Data Layer project in the VS2019 PMC (in your Tools menu option-&gt;Nuget Package\n		Manager -&gt; Package Manager Console)</li>\n	<li><code>Install-Package Microsoft.EntityFrameworkCore.SqlServer</code></li>\n	<li><code>Install-Package Microsoft.EntityFrameworkCore.Tools</code></li>\n	<li><code>Install-Package Microsoft.EntityFrameworkCore.Design</code></li>\n	<li>Build the project before Scaffolding</li>\n	<li>\n		<code>Get-Help about_EntityFrameworkCore</code> - See the EF help commands</li>\n	<li>\n		<code>Scaffold-DbContext -connection \"Server=&lt;DB Server Name&gt;;Database=&lt;DB Name&gt;;user id=&lt;username&gt;;Password=&lt;password&gt;;\" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir &lt;Output Directory name&gt; -context &lt;context name&gt;</code>\n		- Its is mandatory to provide connectio string and the provider rest parameters are optional</li>\n</ul>\n<h2>\n	<a id=\"user-content-net-core-cli-commands-specially-vscode-users\" class=\"anchor\"\n		href=\"#net-core-cli-commands-specially-vscode-users\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>.NET core CLI COMMANDS\n	(specially VSCODE users)</h2>\n<ul>\n	<li>Run following commands in your Data Layer project in the vscode terminal/gitbash/Command prompt)</li>\n	<li><code>dotnet add package Microsoft.EntityFrameworkCore.SqlServer</code></li>\n	<li><code>dotnet add package Microsoft.EntityFrameworkCore.Design</code></li>\n	<li><code>dotnet add package Microsoft.EntityFrameworkCore.Tool</code></li>\n	<li>\n		<code>dotnet ef</code> - to check EF is installed</li>\n	<li>\n		<code>dotnet ef -h</code> -See the EF help commands</li>\n	<li>\n		<code>dotnet ef dbcontext scaffold -h</code> - see if help about EF Db Context Scaffold commands</li>\n	<li>\n		<code>dotnet ef dbcontext scaffold -connection \"Server=&lt;server name&gt;;Database=&lt;Db Name&gt;;user id=&lt;username&gt;;Password=&lt;password&gt;;\" -provider Microsoft.EntityFrameworkCore.SqlServer -outputDir &lt;Output Directory name&gt; -context &lt;context name&gt;</code>\n		- to get all Entities mapped from database objects to C# classes.</li>\n</ul>\n<p><a href=\"https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx\" rel=\"nofollow\">Reference</a></p>\n<h2>\n	<a id=\"user-content-to-move-the-connection-string-from-generated-dbcontext-file-to-json-configuration-file\"\n		class=\"anchor\" href=\"#to-move-the-connection-string-from-generated-dbcontext-file-to-json-configuration-file\"\n		aria-hidden=\"true\"><span aria-hidden=\"true\" class=\"octicon octicon-link\"></span></a>To move the connection\n	string from generated dbcontext file to JSON configuration file:</h2>\n<ol>\n	<li>add package <code>Microsoft.Extensions.Configuration.Json</code> to the console app. (turns out the other two\n		packages from before are dependencies that are automatically added)</li>\n	<li>add new item to console app project, type \"JSON File\", named \"appsettings.json\", with these contents:</li>\n</ol>\n<pre><code>{\n  \"ConnectionStrings\": {\n    \"&lt;name you give to this data source&gt;\": \"&lt;your connection string&gt;\"\n  }\n}\n</code></pre>\n<ol start=\"3\">\n	<li>right-click on \"appsettings.json\" in the solution explorer, go to Properties, change \"Copy to Output Directory\"\n		to \"Copy if newer\".</li>\n	<li>make a \".gitignore\" file in your solution directory, with the contents \"appsettings.json\".</li>\n	<li>in <code>Program.Main</code> of your console app, add the code:</li>\n</ol>\n<pre><code>var configBuilder = new ConfigurationBuilder()\n    .SetBasePath(Directory.GetCurrentDirectory())\n    .AddJsonFile(\"appsettings.json\", optional: true, reloadOnChange: true);\nIConfigurationRoot configuration = configBuilder.Build();\n</code></pre>\n<ol start=\"6\">\n	<li>to get the options ready to make a dbcontext, use the code (substituting the right stuff):</li>\n</ol>\n<pre><code>var optionsBuilder = new DbContextOptionsBuilder&lt;YourAppDbContext&gt;();\noptionsBuilder.UseSqlServer(configuration.GetConnectionString(\"&lt;name you gave to the data source&gt;\"));\nvar options = optionsBuilder.Options;\n</code></pre>\n<ol start=\"7\">\n	<li>then, when you need to make a dbcontext (to give you to your repository classes):\n		<code>new YourAppDbContext(options)</code>.</li>\n</ol>"
                    }
                }
            };
        }
        public string GetHTML(string wikiURL, string pageURL)
        {
            return notADatabase[wikiURL][pageURL].HTML;
        }

        public string GetMD(string wikiURL, string pageURL)
        {
            return notADatabase[wikiURL][pageURL].MD;
        }

        public void SetHTML(string wikiURL, string pageURL, string content)
        {
            notADatabase[wikiURL][pageURL].HTML = content;
        }

        public void SetMD(string wikiURL, string pageURL, string content)
        {
            notADatabase[wikiURL][pageURL].HTML = content;
        }

        public void NewPage(string wikiURL, string pageURL, string content)
        {
            throw new NotImplementedException();
        }

        public void NewPage(string wikiURL, string pageURL, string pageName, string content)
        {
            throw new NotImplementedException();
        }

        public Storing.Page GetPage(string wikiURL, string pageURL)
        {
            throw new NotImplementedException();
        }

        public Storing.Page GetPageWithMD(string wikiURL, string pageURL)
        {
            throw new NotImplementedException();
        }

        public Storing.Page GetPageWithHTML(string wikiURL, string pageURL)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Storing.Page> GetPopularPages(string wikiURL, uint count)
        {
            throw new NotImplementedException();
        }

        public void SetName(string wikiURL, string pageURL, string newName)
        {
            throw new NotImplementedException();
        }

        public void SetPageDetails(string wikiURL, string pageURL, IEnumerable<PageDetails> details)
        {
            throw new NotImplementedException();
        }
    }
}