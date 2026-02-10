# Release Notes

This directory contains release notes for LightstonePlatform.Products.

## Quick Start

Each release should have a corresponding `.mdx` file following the naming convention `v{VERSION}.mdx` (e.g., `v0.1.30.mdx`).

## File Structure

- **AGENTS.md** - Comprehensive instructions for AI agents creating release notes
- **index.mdx** - Central index listing all releases
- **v*.*.*.mdx** - Individual release note files

## Creating a Release Note

1. Create a new file named `v{VERSION}.mdx` (e.g., `v0.2.0.mdx`)
2. Include frontmatter with required fields:
   ```yaml
   ---
   title: Release v{version}
   description: Brief description
   date: YYYY-MM-DD
   version: {version}
   ---
   ```
3. Add the release content following the template in AGENTS.md
4. Update `index.mdx` to add the new release to the top of the list

## GitHub Integration

When a release is created via the CI workflow, the system will:
- Look for a release notes file matching the version
- Extract the content (excluding frontmatter)
- Publish it as the GitHub release description
- Use a default message if no release notes are found

## Template Structure

Recommended sections (in order):
1. **Executive Summary** (Required) - Brief overview of all changes
2. **Overview** - High-level description of the release
3. **Features** - New features and enhancements
4. **Bug Fixes** - Resolved issues
5. **Breaking Changes** - API or behavior changes requiring action
6. **Security Updates** - Security-related fixes
7. **Performance Improvements** - Performance enhancements
8. **Dependencies** - Significant dependency updates
9. **Known Issues** - Any known issues in the release
10. **Contributors** - Recognition of contributors

See **AGENTS.md** for detailed instructions and best practices.
