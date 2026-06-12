from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]

PROGRESS_FILE = ROOT / "RNGReporter" / "Progress.cs"
MANAGER_FILES = [
    ROOT / "RNGReporter" / "TimeFinder3rd.cs",
    ROOT / "RNGReporter" / "TimeFinder4th.cs",
    ROOT / "RNGReporter" / "TimeFinder5th.cs",
    ROOT / "RNGReporter" / "EntralinkSeedSearch.cs",
    ROOT / "RNGReporter" / "Objects" / "Searchers" / "Searcher.cs",
    ROOT / "RNGReporter" / "DSIDWizard.cs",
    ROOT / "RNGReporter" / "UnovaLinkCalibration.cs",
]


def read(path):
    return path.read_text(encoding="utf-8-sig")


def main():
    failures = []

    progress_source = read(PROGRESS_FILE)
    if 'throw new Exception("\u64cd\u4f5c\u88ab\u53d6\u6d88")' in progress_source:
        failures.append("Progress cancellation still throws a generic localized Exception.")
    if "throw new OperationCanceledException" not in progress_source:
        failures.append("Progress cancellation does not throw OperationCanceledException.")

    for path in MANAGER_FILES:
        source = read(path)
        if 'exception.Message != "Operation Cancelled"' in source:
            failures.append(f"{path.relative_to(ROOT)} still detects cancellation by English message.")
        if "catch (OperationCanceledException)" not in source:
            failures.append(f"{path.relative_to(ROOT)} does not catch OperationCanceledException.")

    sortable_managers = MANAGER_FILES[:5]
    for path in sortable_managers:
        source = read(path)
        if "gridSorter" in source and "if (!cancelled)" not in source:
            failures.append(f"{path.relative_to(ROOT)} can still sort large result grids after cancellation.")

    if failures:
        raise SystemExit("\n".join(failures))

    print("progress cancellation checks passed")


if __name__ == "__main__":
    main()
