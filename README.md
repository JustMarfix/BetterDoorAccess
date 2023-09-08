# BetterDoorAccess

An easily configurable plugin for managing keycards rights to access doors.


Config example:
```yaml
better_door_access:
  # Is plugin enabled? (bool)
  is_enabled: true
  # Is Debug enabled? (bool)
  debug: false
  # List of doors for changing access (List<DoorProperties>)
  doors:
  # Door type (DoorType)
  - type: Intercom
    # List of keycards that need to be given access / take away access (true in order to give and false in order to take away) (Dictionary<ItemType, bool>)
    keycards:
      KeycardGuard: true
      KeycardMTFCaptain: false
```
