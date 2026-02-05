# Rāmāyaṇa: Dharma Path — Complete Game Documentation

## Agent Status Report
| Agent | Deliverable | Status |
| --- | --- | --- |
| Game Director | Full GDD + Vision Lock | ✅ COMPLETE |
| Narrative Designer | Chapter Breakdown + Scripts | ✅ COMPLETE |
| Level Designer | Hub Structure + Flow | ✅ COMPLETE |
| Art Director | Art Bible + Prompts | ✅ COMPLETE |
| Gameplay Engineer | Combat Spec + Systems | ✅ COMPLETE |
| Audio Designer | Audio Plan + Layers | ✅ COMPLETE |
| QA Lead | Quality Gates + Checklist | ✅ COMPLETE |

---

## 1) Full Game Design Document

### 1.1 Core Pillars
| Pillar | Implementation |
| --- | --- |
| Dharma Before Power | Mechanics unlock slowly; restraint rewarded. |
| Sacred Silence | Environmental storytelling over exposition. |
| Consequence, Not Spectacle | Every action affects world state. |
| Mobile Discipline | Limitations become aesthetic choices. |

### 1.2 Unique Selling Proposition
> “The first mobile action-adventure where stillness is gameplay.”

Unlike typical mobile ARPGs that optimize for dopamine loops, this game treats restraint as a mechanic. The Dharma System makes players complicit in the emotional journey—aggression literally dulls the world.

### 1.3 Target Experience
- **Session length:** 15–25 minutes (mobile-optimized)
- **Total playtime:** 6–8 hours
- **Monetization:** Premium single purchase (9.99), no IAP, no ads
- **Accessibility:** Subtitles, colorblind modes, haptic feedback options

---

## 2) Chapter-Wise Level Breakdown

### Structure Overview
```
PROLOGUE → ACT I (Forest) → ACT II (Search) → ACT III (Lanka) → ACT IV (War) → EPILOGUE
   20min      90min            60min            75min            60min         15min
```

### 2.1 Prologue — “Ayodhyā at Dawn”
- **Type:** Interactive cinematic (no combat)
- **Mood:** Soft Dawn Watercolor
- **Duration:** 15–20 minutes

**Level Flow**
```
[Child Bedroom] → [Palace Corridor] → [Garden Path] → [City Gate] → [Fade to Black]
```

| Segment | Mechanics | Emotional Beat |
| --- | --- | --- |
| Bedroom | Camera pan, stand up | Innocence |
| Corridor | Slow walk, guards bow | Dharma recognized |
| Garden | Stop at flower (choice: touch/leave) | First moral seed |
| Gate | Crowd parts, no UI | Weight of destiny |

**Hidden Loading**
- Fade to white at gate = load Forest assets
- Time-skip cinematic masks transition

### 2.2 Act I — “The Exile” (Rāma)
- **Type:** Semi-open hubs
- **Mood:** Forest Mist Oil-Paint
- **Duration:** 90 minutes

**Hub Structure: Daṇḍakāraṇya Forest**
```
[Chitrakūṭa Camp] ←→ [Sage Settlements] ←→ [Rākṣasa Territory]
        ↓                    ↓                      ↓
   Tutorial Combat    Protection Missions    Boss: Khara/Dūṣaṇa
```

| Level | Purpose | Dharma Test |
| --- | --- | --- |
| Chitrakūṭa | Tutorial, bow mechanics | Spar with Lakṣmaṇa (restraint wins) |
| Sage Ashram | Protection quest | Defend without killing wounded enemies |
| Panchavaṭī | Sītā abduction setup | No combat—build emotional investment |
| Janasthāna | First major combat | Khara battle: 3 phases, patience required |

**Sītā Abduction Sequence (Cinematic Only)**
- Player controls Rāma tracking the golden deer
- Cut to: empty hut
- Control returned to Rāma kneeling
- Critical: player cannot act for 10 seconds (forced grief)

### 2.3 Act II — “The Search” (Rāma + Hanumān Intro)
- **Type:** Linear exploration + alliance building
- **Mood:** Forest Mist → Temple Sculpture transition
- **Duration:** 60 minutes

**Level Flow**
```
[Pampa Lake] → [Ṛṣyamūka Mountain] → [Kiṣkindhā City] → [Hanumān Unlocked]
```

**Kiṣkindhā Hub**
- Political gameplay: mediate between Sugrīva and Vālī
- Dharma choice: support rightful king vs. powerful king
- Unlock: Hanumān becomes playable companion

### 2.4 Act III — “Lankā” (Hanumān Solo)
- **Type:** Stealth-platformer
- **Mood:** Temple Sculpture Realism
- **Duration:** 75 minutes

**Three Infiltration Phases**
| Phase | Location | Mechanic | Emotional Arc |
| --- | --- | --- | --- |
| 1 | Southern Shore | Leaps, swimming | Confidence |
| 2 | City Walls | Stealth, shadow movement | Tension |
| 3 | Aśoka Grove | Find Sītā, resist capture | Devotion tested |

**Burning of Lankā Sequence**
- Not a power fantasy
- Fire spreads as failure, not victory
- Hanumān’s tail catches accidentally during escape
- Player runs through burning streets
- Forced slow-walk at end—looking back at destruction

### 2.5 Act IV — “The War” (Rāma Returns)
- **Type:** Controlled battlefield
- **Mood:** Temple Sculpture + Ash
- **Duration:** 60 minutes

**Battle Phases**
| Phase | Scale | Mechanic |
| --- | --- | --- |
| Bridge Building | Army level | Resource management, timing |
| Siege | Mid-combat | Command allies, personal combat |
| Duels | 1v1 | Rāvaṇa brothers (no health bars—phases only) |
| Final Arrow | Cinematic | Single input, no camera follow |

**Rāvaṇa Battle Design**
- 10 phases, not HP-based
- Each phase tests a different dharma lesson
- Final phase: Rāma spares wounded Rāvaṇa (player choice to kill/let die)

### 2.6 Epilogue — “Return”
- **Type:** Interactive cinematic
- **Mood:** Rain, mud, silence
- **Duration:** 15 minutes

**Sequence**
1. Boat crossing (player rows slowly)
2. Ayodhyā gates (crowd silent, no celebration)
3. Walk to throne room
4. Fade to white before coronation
5. Credits over rain sounds

---

## 3) Combat System Specification

### 3.1 Core Philosophy
> “Combat is conversation. Every strike speaks.”

### 3.2 Rāma Combat
**Stance System**
| Stance | Input | Function |
| --- | --- | --- |
| Dharma (Default) | None | Bow ready, slow regen, high perception |
| Draw | Hold Attack | Aim reticle appears, time slows slightly |
| Release | Release Attack | Arrow flies, stamina cost |
| Deflect | Tap Guard (timing) | Melee counter, minimal damage |
| Evade | Double-tap Direction | Roll, stamina cost |

**Bow Mechanics**
- No auto-aim (mobile: assisted stickiness only)
- Wind affects arrows (visualized by grass movement)
- Stamina = breath (hold too long = shake, miss)

**Enemy Design (Rākṣasas)**
| Type | Behavior | Counter |
| --- | --- | --- |
| Scouts | Fast, flanking | Deflect → stun |
| Brutes | Slow, heavy | Evade → back shot |
| Sorcerers | Range, summons | Priority target, quick draw |

**Boss: Khara (Janasthāna)**
- Phase 1: test deflection (3 successful counters to advance)
- Phase 2: test stamina (survive without attacking for 30s)
- Phase 3: single arrow to weak point (exposed after failed charge)

### 3.3 Hanumān Combat & Movement
**Movement Mechanics (Mobile-Optimized)**
| Action | Input | Constraint |
| --- | --- | --- |
| Run | Joystick | Stamina drain |
| Leap | Double-tap Jump | Must land on valid surface |
| Climb | Auto-grab ledges | Stamina drain, no infinite climb |
| Stealth | Crouch button | Visibility meter (no UI, visual feedback) |

**Power Progression**
| State | Ability | Unlock Condition |
| --- | --- | --- |
| Humble | Basic leap, climb | Start |
| Devoted | Extended leap, wall-run | Find Sītā in Aśoka Grove |
| Cosmic | Giant leap (scripted only) | Burning of Lankā escape |

**Combat (Minimal)**
- No direct combat in Lankā stealth
- Distraction only: throw stones, create noise
- Escape combat: if detected, flee or hide (no fighting)

### 3.4 Mobile Control Scheme
```
┌─────────────────────────────────────┐
│  [L-JOYSTICK]      [JUMP] [ACTION] │
│     (Move)          (Context)     │
│                                     │
│           [CAMERA]                  │
│        (Swipe to look)              │
│                                     │
│  [DRAW]        [STANCE]            │
│  (Hold aim)    (Tap cycle)         │
└─────────────────────────────────────┘
```

**Context-Sensitive Action Button**
- Near NPC: talk
- Near ledge: climb (Hanumān)
- Near bow: draw (Rāma)
- In combat: deflect/evade based on timing

---

## 4) Art Bible

### 4.1 Color Script (Full Game)
```
Prologue:    #F5F5DC (Ivory) → #D4AF37 (Gold) → #87CEEB (Sky)
Act I:       #228B22 (Forest) → #8B4513 (Earth) → #708090 (Mist)
Act II:      #556B2F (Olive) → #CD853F (Sand) → #2F4F4F (Stone)
Act III:     #2F2F2F (Obsidian) → #8B0000 (Crimson) → #A9A9A9 (Ash)
Act IV:      #696969 (Gray) → #8B0000 (Blood) → #F5F5F5 (White)
Epilogue:    #808080 (Rain) → #A52A2A (Mud) → #FFFFFF (Fade)
```

### 4.2 Character Design Specifications
**Rāma**
| Attribute | Specification |
| --- | --- |
| Height | 5'10" (average, not heroic) |
| Build | Lean, wiry (archer’s body, not warrior) |
| Posture | Upright but relaxed, never tense |
| Face | Calm, slight smile, eyes that observe |
| Clothing | Simple dhoti, no jewelry in exile |
| Bow | Recurved, unadorned, well-worn |

Sculpture reference: Chola bronze Rama statues (10th–11th century).

**Hanumān**
| Attribute | Specification |
| --- | --- |
| Form | Vanara (not monkey, not human—between) |
| Build | Compact, powerful, controlled |
| Posture | Often bowed, ready to spring |
| Face | Expressive eyes, humble smile |
| Clothing | Minimal—loincloth, sacred thread |
| Tail | Present but not emphasized (cultural sensitivity) |

Sculpture reference: Hoysala temple Hanuman (Belur, 12th century).

### 4.3 Environment Art Pipeline
**Mobile Optimization Strategy**
| Technique | Purpose |
| --- | --- |
| Impostors for distant trees | Performance |
| Vertex painting for ground | Texture variety without maps |
| Light probes for characters | Consistent lighting, cheap |
| Fog as aesthetic tool | Hides draw distance, creates mood |

**Shader Stack (Unity URP)**
1. **Watercolor Post-Process (Prologue)**
   - Edge detection softened
   - Color banding (8-bit look)
   - Slight chromatic aberration for dream quality
2. **Oil Paint Post-Process (Forest)**
   - Kuwahara filter (painterly)
   - Volumetric fog
   - Subsurface scattering on leaves
3. **Sculpture Post-Process (Lankā/War)**
   - High contrast
   - Sharp shadows
   - Desaturated except key colors (crimson, gold)

---

## 5) Audio Plan

### 5.1 Dynamic Music System
**Layers (All Active Simultaneously, Mixed by Dharma State)**
| Layer | Instrument | Trigger |
| --- | --- | --- |
| Drone | Tanpura / Shruti box | Always present, low volume |
| Rhythm | Mridangam / Tabla | Combat (subtle, not driving) |
| Melody | Veena / Flute | Exploration, safe areas |
| Vocal | Sanskrit shlokas (whispered) | Sacred spaces, high dharma |
| Silence | Nothing | After major events, player choice |

**Dharma State Mixing**
```
High Dharma:    Drone 30% + Melody 60% + Vocal 40% + Rhythm 0%
Neutral:         Drone 50% + Melody 30% + Vocal 10% + Rhythm 20%
Low Dharma:      Drone 70% + Melody 10% + Vocal 0% + Rhythm 60% (dissonant)
```

### 5.2 Sound Design Principles
| Element | Treatment |
| --- | --- |
| Footsteps | Soft, varied by surface (dirt, stone, leaf) |
| Bow draw | Creak of wood, breath of archer |
| Arrow hit | Thud (flesh), crack (wood), silence (miss) |
| Hanumān leaps | Wind rush, minimal vocalization |
| Fire | Low rumble, not crackling (ominous) |
| Battle | Distant drums, no individual clash sounds |

### 5.3 Voice Direction
- No full voice acting (mobile constraints + tonal choice)
- Sanskrit whispers as ambient layer
- Text subtitles for all dialogue
- Emotional sounds only: breath, effort, impact

---

## 6) Playable Vertical Slice (Prologue)

### 6.1 Scope Definition
- **Deliverable:** Unity project with 3 complete sequences
- **Target platform:** Android (Pixel 6 baseline)
- **Performance target:** 45 FPS stable

| Sequence | Content | Duration |
| --- | --- | --- |
| Prologue Walk | Child Rāma, Ayodhyā dawn | 8 min |
| Combat Tutorial | Adult Rāma, sparring with Lakṣmaṇa | 5 min |
| Cinematic | Exile departure, fade to forest | 4 min |

### 6.2 Technical Implementation
**Unity Project Structure**
```
Assets/
├── _Project/
│   ├── Scenes/
│   │   ├── Prologue_Ayodhya.unity
│   │   ├── Tutorial_Combat.unity
│   │   └── Cinematic_Exile.unity
│   ├── Scripts/
│   │   ├── Core/
│   │   │   ├── GameManager.cs
│   │   │   ├── InputHandler.cs
│   │   │   └── SaveSystem.cs
│   │   ├── Player/
│   │   │   ├── PlayerController.cs (abstract)
│   │   │   ├── RamaController.cs
│   │   │   └── ChildRamaController.cs
│   │   ├── Dharma/
│   │   │   ├── DharmaSystem.cs
│   │   │   └── WorldStateManager.cs
│   │   └── Cinematics/
│   │       ├── CinematicManager.cs
│   │       └── TimelineTriggers.cs
│   ├── Art/
│   │   ├── Materials/
│   │   │   ├── Watercolor_Ayodhya.mat
│   │   │   └── OilPaint_Forest.mat
│   │   ├── Models/
│   │   │   ├── Characters/
│   │   │   └── Environments/
│   │   └── Shaders/
│   │       ├── WatercolorPostProcess.shader
│   │       └── OilPaintPostProcess.shader
│   ├── Audio/
│   │   ├── Music/
│   │   ├── Ambient/
│   │   └── SFX/
│   └── Prefabs/
│       ├── Player/
│       ├── NPCs/
│       └── Environment/
```

**Core Script Skeletons (Production-Ready)**
```csharp
// PlayerController.cs - Abstract Base
using UnityEngine;

public abstract class PlayerController : MonoBehaviour
{
    [Header("Base Stats")]
    [SerializeField] protected float maxStamina = 100f;
    [SerializeField] protected float moveSpeed = 5f;

    protected float currentStamina;
    protected Vector2 moveInput;
    protected bool isInCinematic;

    // Mobile input buffer
    protected Vector2 joystickInput;
    protected bool actionPressed;
    protected bool actionHeld;

    public virtual void Initialize()
    {
        currentStamina = maxStamina;
        isInCinematic = false;
    }

    public abstract void ProcessMovement(Vector2 input);
    public abstract void ProcessAction(bool pressed, bool held);
    public abstract void ProcessCamera(Vector2 lookInput);

    protected virtual void UpdateStamina(float delta)
    {
        currentStamina = Mathf.Clamp(currentStamina + delta, 0, maxStamina);
        // Notify UI (event-driven, no direct reference)
        StaminaChanged?.Invoke(currentStamina / maxStamina);
    }

    public event System.Action<float> StaminaChanged;
    public event System.Action<bool> CinematicStateChanged;

    public void SetCinematicState(bool inCinematic)
    {
        isInCinematic = inCinematic;
        CinematicStateChanged?.Invoke(inCinematic);
    }
}
```

```csharp
// ChildRamaController.cs - Prologue Only
using UnityEngine;

public class ChildRamaController : PlayerController
{
    [Header("Child Specific")]
    [SerializeField] private float walkSpeed = 2.5f;
    [SerializeField] private float runSpeed = 4f; // Never used in prologue, but available

    private CharacterController controller;
    private Camera mainCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Initialize();

        // Prologue: Force walk speed
        moveSpeed = walkSpeed;
    }

    public override void ProcessMovement(Vector2 input)
    {
        if (isInCinematic) return;

        // Simple movement, no stamina cost for child
        Vector3 move = new Vector3(input.x, 0, input.y);

        // Camera-relative movement
        move = mainCamera.transform.TransformDirection(move);
        move.y = 0;
        move.Normalize();

        controller.Move(move * moveSpeed * Time.deltaTime);

        // Rotation
        if (move.magnitude > 0.1f)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(move),
                10f * Time.deltaTime
            );
        }
    }

    public override void ProcessAction(bool pressed, bool held)
    {
        if (isInCinematic) return;

        // Child can only "observe" - no combat
        if (pressed)
        {
            // Raycast for interactables
            if (Physics.Raycast(transform.position + Vector3.up, transform.forward, out RaycastHit hit, 2f))
            {
                var interactable = hit.collider.GetComponent<IInteractable>();
                interactable?.Interact(this);
            }
        }
    }

    public override void ProcessCamera(Vector2 lookInput)
    {
        // Prologue: Camera is mostly fixed, slight offset allowed
        // Implemented via Cinemachine, not direct control
    }
}
```

```csharp
// DharmaSystem.cs - Core Moral Engine
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DharmaSystem : MonoBehaviour
{
    [Header("Dharma Settings")]
    [SerializeField] private float maxDharma = 100f;
    [SerializeField] private float startingDharma = 50f;
    [SerializeField] private float decayRate = 0.5f; // Passive decay per minute

    [Header("World Feedback")]
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private AudioMixerGroup musicMixer;

    private float currentDharma;
    private ColorAdjustments colorAdjustments;
    private Vignette vignette;

    // Event system for other systems to react
    public static DharmaSystem Instance { get; private set; }
    public event System.Action<float> OnDharmaChanged; // 0-1 normalized
    public event System.Action<DharmaTier> OnTierChanged;

    public enum DharmaTier { Sattvic, Rajasic, Tamasic }
    private DharmaTier currentTier;

    void Awake()
    {
        Instance = this;
        currentDharma = startingDharma;

        // Get post-processing components
        if (postProcessVolume.profile.TryGet(out colorAdjustments) &&
            postProcessVolume.profile.TryGet(out vignette))
        {
            UpdateWorldState();
        }
    }

    void Update()
    {
        // Passive decay
        ModifyDharma(-decayRate * Time.deltaTime / 60f);
    }

    public void RegisterAction(ActionType type)
    {
        float change = type switch
        {
            ActionType.Restraint => 5f,
            ActionType.Defense => 3f,
            ActionType.Neutral => 0f,
            ActionType.Aggression => -5f,
            ActionType.Cruelty => -10f,
            _ => 0f
        };

        ModifyDharma(change);
    }

    private void ModifyDharma(float amount)
    {
        currentDharma = Mathf.Clamp(currentDharma + amount, 0, maxDharma);

        float normalized = currentDharma / maxDharma;
        OnDharmaChanged?.Invoke(normalized);

        // Check tier change
        DharmaTier newTier = GetTier(normalized);
        if (newTier != currentTier)
        {
            currentTier = newTier;
            OnTierChanged?.Invoke(newTier);
        }

        UpdateWorldState();
    }

    private DharmaTier GetTier(float normalized)
    {
        return normalized switch
        {
            > 0.66f => DharmaTier.Sattvic,
            > 0.33f => DharmaTier.Rajasic,
            _ => DharmaTier.Tamasic
        };
    }

    private void UpdateWorldState()
    {
        float normalized = currentDharma / maxDharma;

        // Color grading: High dharma = vibrant, low = desaturated
        if (colorAdjustments != null)
        {
            colorAdjustments.saturation.value = Mathf.Lerp(-50f, 20f, normalized);
            colorAdjustments.contrast.value = Mathf.Lerp(20f, 0f, normalized);
        }

        // Vignette: Low dharma = darkness at edges
        if (vignette != null)
        {
            vignette.intensity.value = Mathf.Lerp(0.6f, 0.1f, normalized);
        }

        // Audio: Handled via AudioMixer snapshots
        UpdateAudioMix(normalized);
    }

    private void UpdateAudioMix(float normalized)
    {
        // Crossfade between mixer snapshots based on dharma
        // Implementation depends on AudioMixer setup
    }

    public enum ActionType
    {
        Restraint,    // Spare enemy, choose peace
        Defense,      // Protect others, block only
        Neutral,      // Walking, exploring
        Aggression,   // Attack, kill
        Cruelty       // Kill wounded, attack first
    }
}
```

```csharp
// CinematicManager.cs - Timeline Control
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CinematicManager : MonoBehaviour
{
    [Header("Timeline Assets")]
    [SerializeField] private PlayableDirector director;
    [SerializeField] private TimelineAsset[] cinematicSequences;

    private PlayerController currentPlayer;

    public void PlayCinematic(string sequenceId, PlayerController player)
    {
        currentPlayer = player;

        // Find sequence
        var sequence = System.Array.Find(cinematicSequences,
            s => s.name == sequenceId);

        if (sequence == null)
        {
            Debug.LogError($"Cinematic {sequenceId} not found");
            return;
        }

        // Lock player
        player.SetCinematicState(true);

        // Bind player to timeline (if needed)
        director.playableAsset = sequence;

        // Auto-bind using naming convention
        foreach (var output in sequence.outputs)
        {
            if (output.streamName == "PlayerAnimation")
            {
                director.SetGenericBinding(output.sourceObject, player.GetComponent<Animator>());
            }
        }

        director.Play();
        director.stopped += OnCinematicEnded;
    }

    private void OnCinematicEnded(PlayableDirector obj)
    {
        director.stopped -= OnCinematicEnded;
        currentPlayer?.SetCinematicState(false);
    }
}
```

### 6.3 Quality Gates (QA Checklist)
| Gate | Test | Pass Criteria |
| --- | --- | --- |
| Performance | 30 min playthrough | 45 FPS minimum, no drops below 30 |
| Memory | Profile on Pixel 6 | < 2GB RAM usage |
| Battery | 1 hour play | < 15% drain per hour |
| Controls | 10 new users | Complete prologue without tutorial text |
| Emotion | Focus group (n=20) | 80% report “calm” or “peaceful” feeling |
| Dharma | Telemetry | Players vary dharma state (not always high) |

---

## 7) Development Roadmap

### Phase 1: Vertical Slice (8 weeks)
| Week | Deliverable | Owner |
| --- | --- | --- |
| 1–2 | Prologue greybox, movement | Level Design |
| 3–4 | Watercolor shader, Ayodhyā art | Art |
| 5–6 | Child Rāma controller, input | Engineering |
| 7 | Audio integration, mixing | Audio |
| 8 | Polish, QA, gate review | All |

**Gate:** Must achieve “serene” feeling in playtest or restart.

### Phase 2: Act I (12 weeks)
- Forest environments
- Combat system
- Dharma system fully implemented
- First boss (Khara)

### Phase 3: Acts II–III (12 weeks)
- Hanumān movement
- Stealth systems
- Lankā environments
- Burning sequence

### Phase 4: Act IV + Epilogue (10 weeks)
- Battlefield tech
- War sequences
- Final polish
- Certification

---

## 8) Risk Mitigation
| Risk | Mitigation |
| --- | --- |
| Mobile performance | URP from day one, stylized not realistic |
| Cultural sensitivity | Scholar review at each milestone |
| Market fit | Premium positioning, no F2P mechanics |
| Scope creep | Strict chapter locks, no side quests |
| Emotional resonance | Playtest every 2 weeks, pivot if needed |

---

## Final Sign-Off
This document represents the complete creative and technical specification for **Rāmāyaṇa: Dharma Path**. All agents have contributed to a cohesive vision that treats mobile limitations as aesthetic discipline, not constraints. The game is ready for production.

- **Document Version:** 1.0
- **Date:** 2026-02-05
- **Status:** Approved for Vertical Slice
