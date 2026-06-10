# THIRD_PARTY_NOTICES.md

## Third-Party Software Notices and Attributions

This document lists third-party open-source software components used, adapted, or ported within the **Open-Tester-Engineering** repository.

All included software is distributed in accordance with the terms of its original licenses.

---

## 1. General Notice

This repository contains software derived from third-party open-source projects.

Each component retains its original copyright, authorship, and license terms.

No ownership is claimed over upstream works except for documented modifications.

All modifications are provided under the same license terms as the original software where required.

---

## 2. Component Attribution

### 2.1 ISO-TP / Transport Protocol Implementations

- **Project:** ISO-TP / ISO 15765 Transport Layer Implementations  
- **Original Source:** Various open-source implementations (see individual files for exact origin)  
- **License:** GPL and/or MIT (varies by upstream source)  
- **Usage:** Adapted and ported into C# for use in CAN/diagnostic transport abstraction  
- **Modifications:**
  - Language port from original implementation language into C#
  - Refactoring for integration with CAN abstraction layer
  - Removal or replacement of platform-specific dependencies where applicable

---

### 2.2 UDS / Diagnostic Service Implementations

- **Project:** Unified Diagnostic Services (ISO 14229) tooling and helpers  
- **Original Source:** Open-source UDS tooling projects (see file-level headers for attribution)  
- **License:** GPL and/or MIT depending on upstream source  
- **Usage:** Diagnostic request/response structures and service helpers  
- **Modifications:**
  - Ported into C# environment
  - API restructuring for modular service usage
  - Separation of transport and diagnostic layers

---

### 2.3 CAN Communication Utilities

- **Project:** CAN frame handling and abstraction utilities  
- **Original Source:** Multiple open-source CAN toolkits  
- **License:** MIT / GPL (varies by module)  
- **Usage:** Frame encoding/decoding, filtering, and basic bus interaction  
- **Modifications:**
  - Unified interface layer for multiple CAN backends
  - C# translation and type safety improvements

---

### 2.4 Flash Programming Routines

- **Project:** ECU flashing and firmware transfer utilities  
- **Original Source:** Open-source flashing tools and protocol implementations  
- **License:** GPL (in applicable components)  
- **Usage:** ECU programming sequence logic and data transfer routines  
- **Modifications:**
  - Ported into C#
  - Refactored into modular step-based flashing pipeline
  - Decoupled from UI and proprietary workflow systems

---

## 3. License Compliance

All components are distributed under their original licenses.

Where GPL-licensed components are included:

- The corresponding source code is made available in full
- Any modifications are disclosed and included in this repository
- Redistribution is performed in accordance with GPL requirements

Where MIT-licensed components are included:

- Original copyright notices are preserved
- License text is included without modification

---

## 4. File-Level Attribution

Where possible, individual source files contain:

- Original author attribution headers
- Original source repository references
- License identifiers
- Modification notes (if applicable)

If file-level attribution is not present, it is documented in this file.

---

## 5. Separation From Proprietary Software

This repository contains **no proprietary code** from the Tester Engineering Suite.

It is independently maintained and distributed solely for compliance with third-party open-source licenses.

No proprietary binaries, logic, or internal system components are included.

---

## 6. Disclaimer

This software is provided “as is”, without warranty of any kind.

All third-party software is the property of its respective authors and contributors.
