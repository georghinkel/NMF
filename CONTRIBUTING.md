# Contributing to the .NET Modeling Framework
We would love for you to contribute to the .NET Modeling Framework and help make it even better than it is
today! As a contributor, here are the guidelines we would like you to follow:
 - [Question or Problem?](#question)
 - [Issues and Bugs](#issue)
 - [Feature Requests](#feature)
 - [Submission Guidelines](#submit)
## <a name="question"></a> Got a Question or Problem?
Please do not hesitate to contact [Georg Hinkel by email][georg-email].
## <a name="issue"></a> Found a Bug?
If you find a bug in the source code, you can help us by
[submitting an issue](#submit-issue) to our [GitHub Repository][github]. Even better, you can
[submit a Pull Request](#submit-pr) with a fix.
## <a name="feature"></a> Missing a Feature?
You can *request* a new feature by [submitting an issue](#submit-issue) to our GitHub
Repository. If you would like to *implement* a new feature, please submit an issue with
a proposal for your work first, to be sure that we can use it.
Please consider what kind of change it is:
* For a **Major Feature**, first open an issue and outline your proposal so that it can be
discussed. This will also allow us to better coordinate our efforts, prevent duplication of work,
and help you to craft the change so that it is successfully accepted into the project.
* **Small Features** can be crafted and directly [submitted as a Pull Request](#submit-pr).
## <a name="submit"></a> Submission Guidelines
### <a name="submit-issue"></a> Submitting an Issue
Before you submit an issue, please search the issue tracker, maybe an issue for your problem already
exists and the discussion might inform you of workarounds readily available.
We want to fix all the issues as soon as possible, but before fixing a bug we need to reproduce and
confirm it. In order to reproduce bugs we will need as much information as possible, and preferably
be in touch with you to gather information. Please make sure that you include a contact email address
in the issue content or, even better, include a unit test that makes the bug obvious.
You can file new issues by filling out our [new issue form][new-issue-form].
### <a name="submit-pr"></a> Submitting a Pull Request (PR)
Before you submit your Pull Request (PR) consider the following guidelines:
* Make your changes in a new git branch:
     ```shell
     git checkout -b my-fix-branch master
     ```
* Create your patch, **including appropriate test cases**.
* Run the full test suite, and ensure that all tests pass.
* Commit your changes using a descriptive commit message.
     ```shell
     git commit -a
     ```
  Note: the optional commit `-a` command line option will automatically “add” and “rm” edited files.
* Push your branch to GitHub:
    ```shell
    git push origin my-fix-branch
    ```
* In GitHub, send a pull request to the `master` branch of the relevant component.
* If we suggest changes then:
  * Make the required updates.
  * Re-run the test suites to ensure tests are still passing.
  * Rebase your branch and force push to your GitHub repository (this will update your Pull Request):
    ```shell
    git rebase master -i
    git push -f
    ```
That’s it! Thank you for your contribution!
#### After your pull request is merged
After your pull request is merged, you can safely delete your branch and pull the changes
from the main (upstream) repository:
* Delete the remote branch on GitHub either through the GitHub web UI or your local shell as follows:
    ```shell
    git push origin --delete my-fix-branch
    ```
* Check out the master branch:
    ```shell
    git checkout master -f
    ```
* Delete the local branch:
    ```shell
    git branch -D my-fix-branch
    ```
* Update your master with the latest upstream version:
    ```shell
    git pull --ff upstream master
    ```

[georg-email]: mailto:hinkel@fzi.de
[github]: https://github.com/NMFCode/NMF