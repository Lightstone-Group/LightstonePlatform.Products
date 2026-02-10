# AGENTS.md - Release Notes Directory

## Purpose

This directory contains release notes for the Apex project (previously known as the Platform project). Release notes document features, bug fixes, breaking changes, and other important information for each version release.

## Directory Structure

```
release-notes/
├── AGENTS.md           # This file - instructions for AI agents
├── index.mdx          # Main index listing all releases
└── v*.*.*.mdx         # Individual release note files (e.g., v1.2.3.mdx)
```

## Versioning

The project follows **Semantic Versioning (SemVer)**:
- **MAJOR.MINOR.PATCH** (e.g., 2.1.3)
- **MAJOR**: Breaking changes
- **MINOR**: New features (backward compatible)
- **PATCH**: Bug fixes (backward compatible)

## File Naming Convention

Release note files must follow this naming pattern:
- Format: `v{MAJOR}.{MINOR}.{PATCH}.mdx`
- Examples: `v1.0.0.mdx`, `v2.1.3.mdx`, `v3.0.0-beta.1.mdx`

## Frontmatter Requirements

Each release note file must include proper frontmatter:

```markdown
---
title: Release v{version}
description: {Brief description of the release}
date: {YYYY-MM-DD}
version: {version number}
---
```

Example:
```markdown
---
title: Release v2.1.0
description: Enhanced API management and performance improvements
date: 2025-11-20
version: 2.1.0
---
```

## index.mdx Structure

The `index.mdx` file should:
1. Include frontmatter with title
2. Provide a brief introduction to the release notes
3. List all releases in reverse chronological order (newest first)
4. Link to individual release files

Example structure:
```markdown
---
title: Release Notes
description: Platform release history and changelog
---

# Release Notes

Welcome to the Platform release notes. Below you'll find detailed information about each release.

## Latest Releases

- [v2.1.0](./v2.1.0.mdx) - 2025-11-20
- [v2.0.0](./v2.0.0.mdx) - 2025-10-15
- [v1.5.3](./v1.5.3.mdx) - 2025-09-30
```

## Creating a New Release Note

When composing a new release file, follow these steps:

### 1. Identify the Release Branch

Determine the release branch name (e.g., `release/v2.1.0`).

### 2. Use Azure DevOps MCP Server

Leverage the Azure DevOps MCP server tools to gather release information:

**Project Information:**
- Azure DevOps Organization: `lsproperty`
- Primary Project: `Platform`
- Project ID: `46a4e437-dbfd-46a9-9a20-dda13e43b4c3`

**Key Tools to Use:**

a) **List repositories:**
```
#mcp_azure-devops_repo_list_repos_by_project
- project: "Platform"
```

b) **Search commits between branches:**
```
#mcp_azure-devops_repo_search_commits
- project: "Platform"
- repository: "{repository-id}"
- fromDate: "{start-date}"
- toDate: "{end-date}"
```

c) **Find pull requests for the release:**
```
#mcp_azure-devops_repo_list_pull_requests_by_repo_or_project
- project: "Platform"
- repositoryId: "{repository-id}"
- targetRefName: "refs/heads/main"
- sourceRefName: "refs/heads/release/{version}"
```

d) **Get work items linked to commits:**
```
#mcp_azure-devops_wit_get_work_items_batch_by_ids
- project: "Platform"
- ids: [array of work item IDs]
```

e) **Search for work items by iteration or query:**
```
#mcp_azure-devops_search_workitem
- searchText: "release {version}"
- project: ["Platform"]
```

### 3. Use Git Commands

Supplement Azure DevOps data with git commands:

```powershell
# Compare release branch with main
git log main..release/v2.1.0 --oneline

# Get detailed commit information
git log main..release/v2.1.0 --pretty=format:"%h - %s (%an)" --date=short

# Find merge commits
git log main..release/v2.1.0 --merges

# Show files changed
git diff main...release/v2.1.0 --name-status
```

### 4. Identify Linked Work Items

- Extract work item IDs from commit messages (format: `#12345` or `AB#12345`)
- Query Azure DevOps for work item details
- Categorize work items by type: Feature, Bug, Task, etc.
- Note any work items marked as breaking changes

### 5. Structure the Release Note

Organize the release note with the following sections in this exact order:

```markdown
---
title: Release v{version}
description: {Brief summary}
date: {YYYY-MM-DD}
version: {version}
---

# Release v{version}

Released on {Month Day, Year}

## Executive Summary

**IMPORTANT:** This section must be included at the beginning of every release note to provide a quick overview of all changes.

### Features

List features grouped by functional area with brief description first, then work item and pull request links:

#### {Feature Category 1}
- Brief description of feature ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))
- Brief description with multiple work items ([[{id1}](url1), [{id2}](url2), [{id3}](url3)]) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))
- Brief description (work item optional if not available) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))

#### {Feature Category 2}
- Brief description of feature ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))

### Bug Fixes
- Brief description of bug fix ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))

**Format Guidelines for Executive Summary:**
- **Content Approach:** Write brief, business-focused, user-friendly descriptions that explain the value or impact of the change
- **Avoid Technical Details:** Don't list specific service names, test methods, or implementation details in the description
- **Group Related Items:** Combine multiple related work items and PRs under a single business-focused description
- Keep descriptions brief and high-level (one line per item)
- Start with the brief description, followed by ALL linked work items and PRs in parentheses
- **Work Item Requirements:**
  - Always include work item links when available (Features, User Stories, Bugs, Tasks)
  - When grouping related child work items (User Stories, Tasks), reference the parent Feature/PBI first, followed by child items
  - If only PRs are available without direct work item links, include just the PRs
  - Example with parent feature: `Brief description ([Feature-ID](url)) ([[Child-1](url), [Child-2](url), [Child-3](url)])`
- Work item links should be in format `([{id}](url))` - **without the # symbol in the link text**
- PR links should be in format `([PR {id}](url))` - **with "PR " prefix and a space, without # symbol**
- **Multiple work items:** Use comma-separated format with individual links: `([[123](url1), [456](url2), [789](url3)])`
- **Multiple PRs:** Use comma-separated format with individual links: `([[PR 123](url1), [PR 456](url2)])`
- **Example 1:** `Significantly improved platform stability through expanded automated testing ([125870](url)) ([[PR 23558](url), [PR 23557](url), [PR 23550](url)])`
- **Example 2:** `Enhanced invoice processing reliability with improved event handling infrastructure ([PR 23579](url)) ([PR 23588](url))`
- **Example 3:** `Improved pricing accuracy by tracking price tiers ([135988](url)) ([[136008](url), [136009](url), [136010](url)]) ([[PR 123](url), [PR 456](url)])`
- Group by functional area (Code Quality & Reliability, User Experience, Billing & Quoting, System Reliability, etc.)
- Focus on business value and user-facing changes, not technical implementation
- Order: Features first, then Bug Fixes, then other categories
- **All work items and PRs must be included** even when grouped under a single business description

## Overview

{Brief overview of the release - 2-3 sentences about major themes}

## Features

{List new features and enhancements}

### {Feature Category 1}

- **{Feature Name}** - {Description} ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))
- **{Feature Name with Multiple Work Items}** - {Description} ([[{id1}](url1), [{id2}](url2)]) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))
- **{Feature Name}** - {Description} ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id}))

### {Feature Category 2}

- **{Feature Name}** - {Description}

## Bug Fixes

{List bug fixes}

- **{Bug Title}** - {Description} ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([PR {pr-id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{pr-id}))
- **{Bug Title with Multiple PRs}** - {Description} ([{work-item-id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{work-item-id})) ([[PR {pr-id1}](url1), [PR {pr-id2}](url2)])

## Breaking Changes

{List breaking changes - CRITICAL section if MAJOR version change}

- **{Breaking Change}** - {Description and migration guide}
  - **Migration:** {Steps to migrate}
  - **Impact:** {Who is affected}

## Security Updates

{List security fixes if applicable}

- **{Security Issue}** - {Description} (Severity: {High/Medium/Low})

## Performance Improvements

{List performance enhancements if applicable}

- **{Area}** - {Improvement description and impact}

## Dependencies

{List significant dependency updates}

- Upgraded `{package}` from v{old} to v{new}
- Added `{package}` v{version}

## Known Issues

{List any known issues in this release}

- **{Issue}** - {Description and workaround if available}

## Contributors

{List contributors if notable}

Thanks to all contributors who made this release possible!
```

### 6. Content Guidelines

**Executive Summary (REQUIRED):**
- **MUST be included** as the first section after the header and release date
- Provides a quick, scannable overview of all changes in the release
- Start with brief description, then links: work item(s) first, then pull request(s)
- Keep descriptions brief (one line per item)
- Group by functional area (Observability, Billing, Product Flows, Infrastructure, etc.)
- Focus on business value and impact
- Use consistent formatting: `Brief description ([ID](url)) ([PR ID](url))`
- **Important:** Do not include # symbol in link text for work items or PRs
- **Multiple IDs:** Use comma-separated format with individual links enclosed in brackets: `([[123](url1), [456](url2)])` or `([[PR 123](url1), [PR 456](url2)])`

**Features:**
- List all new features and enhancements
- Group by functional area or component
- Include work item links
- Use bold for feature names
- Start with most significant features
- Provide detailed descriptions in this section (unlike executive summary)

**Bug Fixes:**
- List all resolved bugs
- Include work item links
- Describe the issue and resolution
- Group by severity if many fixes

**Breaking Changes:**
- **MUST be listed if any exist**
- Provide clear migration instructions
- Explain the rationale for the change
- Include code examples for before/after
- Indicate which users/systems are affected

**Work Item and Pull Request Links:**
- **Single Work Item format:** `([{id}](https://dev.azure.com/lsproperty/Platform/_workitems/edit/{id}))` - without # symbol
- **Multiple Work Items format:** `([[{id1}](url1), [{id2}](url2), [{id3}](url3)])` - each ID gets its own link, comma-separated, enclosed in outer brackets
- **Single PR format:** `([PR {id}](https://dev.azure.com/lsproperty/Platform/_git/Platform/pullrequest/{id}))` - with "PR " prefix and space, without # symbol
- **Multiple PRs format:** `([[PR {id1}](url1), [PR {id2}](url2)])` - each PR gets its own link with "PR " prefix, comma-separated, enclosed in outer brackets
- Include for all features and bug fixes where applicable
- Each work item and PR should link to its respective Azure DevOps page

### 7. Update index.mdx

After creating the release note file:
1. Open `index.mdx`
2. Add the new release to the top of the list
3. Ensure proper formatting and linking
4. Maintain reverse chronological order

## Writing Style Guidelines

- **Be Clear:** Use simple, direct language
- **Be Specific:** Include technical details where relevant
- **Be Consistent:** Follow the established format
- **Be Complete:** Don't omit important information
- **Use Active Voice:** "Added feature X" not "Feature X was added"
- **Link Generously:** Link to work items, documentation, and related resources

## Quality Checklist

Before finalizing a release note, verify:

- [ ] Frontmatter is complete and accurate
- [ ] **Executive Summary section is included as the first section**
- [ ] Executive Summary has proper link formatting with work items and PRs
- [ ] Executive Summary descriptions are brief and high-level
- [ ] All sections are in the correct order (Executive Summary, Overview, Features, Bug Fixes, etc.)
- [ ] Features are listed before bug fixes
- [ ] Breaking changes are listed (if applicable)
- [ ] All work item IDs are linked correctly
- [ ] Version number matches everywhere
- [ ] Date is correct (YYYY-MM-DD format)
- [ ] File name matches version (v{version}.mdx)
- [ ] index.mdx is updated with the new release
- [ ] Grammar and spelling are correct
- [ ] Technical accuracy is verified

## Example Commands for Release v2.1.0

Here's a complete workflow example:

### Step 1: Find the repository
```
Use #mcp_azure-devops_repo_list_repos_by_project with project "Platform"
Identify the main repository (usually "Platform")
```

### Step 2: Get commits for the release
```
Use #mcp_azure-devops_repo_search_commits
- project: "Platform"
- repository: "Platform"
- fromDate: "2025-10-01T00:00:00Z"
- toDate: "2025-11-20T23:59:59Z"
```

### Step 3: Extract work item IDs
```
Parse commit messages for patterns like:
- AB#12345
- Lightstone-Group/LightstonePlatform.Products#12345
- Work Item 12345
```

### Step 4: Get work item details
```
Use #mcp_azure-devops_wit_get_work_items_batch_by_ids
- project: "Platform"
- ids: [12345, 12346, 12347]
```

### Step 5: Find related pull requests
```
Use #mcp_azure-devops_repo_list_pull_requests_by_commits
- project: "Platform"
- repository: "Platform"
- commits: [array of commit IDs]
```

### Step 6: Create the release file
```
Create v2.1.0.mdx with proper structure
```

### Step 7: Update index
```
Add release to index.mdx at the top
```

## Troubleshooting

### Common Issues

**Issue:** Cannot find work items linked to commits
**Solution:** Use multiple search methods:
1. Parse commit messages for IDs
2. Search work items by iteration
3. Query pull request descriptions
4. Use Azure DevOps search with release version

**Issue:** Breaking changes not clearly identified
**Solution:** 
1. Review all MAJOR version commits carefully
2. Check work item tags for "breaking-change"
3. Review API and interface changes
4. Consult with development team

**Issue:** Missing commit information
**Solution:** 
1. Expand date range for commit search
2. Check multiple branches (release, main, develop)
3. Use git log commands as backup
4. Verify repository ID is correct

## Best Practices

1. **Start Early:** Begin drafting release notes during development
2. **Collaborate:** Work with developers to understand changes
3. **Be Thorough:** Don't skip minor fixes or improvements
4. **Test Links:** Verify all work item and documentation links work
5. **Get Review:** Have technical writers or developers review
6. **Update Promptly:** Keep release notes current with each release
7. **Archive Old Releases:** Don't delete old release notes
8. **Use Templates:** Maintain consistency across releases

## Tools Integration

This directory expects integration with:
- **Azure DevOps MCP Server:** For work item and repository data
- **Git:** For commit history and diff information
- **Docusaurus:** For rendering and displaying release notes

## Additional Resources

- [Semantic Versioning Specification](https://semver.org/)
- [Keep a Changelog](https://keepachangelog.com/)
- [Azure DevOps REST API](https://docs.microsoft.com/en-us/rest/api/azure/devops/)
- [Docusaurus Documentation](https://docusaurus.io/)

---

*This AGENTS.md file provides comprehensive guidance for AI agents working with the Platform release notes. Follow these instructions to ensure consistent, accurate, and helpful release documentation.*
