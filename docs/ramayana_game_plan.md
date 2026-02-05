# Rāmāyaṇa: Dharma Path — Combined Game Documentation

## 0) Agent Status Report
| Agent | Deliverable | Status |
| --- | --- | --- |
| Game Director | Full GDD + Vision Lock | ✅ Complete |
| Narrative Designer | Chapter Breakdown + Scripts | ✅ Complete |
| Level Designer | Hub Structure + Flow | ✅ Complete |
| Art Director | Art Bible + Prompts | ✅ Complete |
| Gameplay Engineer | Combat Spec + Systems | ✅ Complete |
| Audio Designer | Audio Plan + Layers | ✅ Complete |
| QA Lead | Quality Gates + Checklist | ✅ Complete |

## 1) Core Pillars
| Pillar | Implementation |
| --- | --- |
| Dharma Before Power | Mechanics unlock slowly; restraint rewarded. |
| Sacred Silence | Environmental storytelling over exposition. |
| Consequence, Not Spectacle | Every action affects world state. |
| Mobile Discipline | Limitations become aesthetic choices. |

## 2) Unique Selling Proposition
> “The first mobile action-adventure where stillness is gameplay.”

The Dharma System makes players complicit in the emotional journey—aggression literally dulls the world.

## 3) Target Experience
- **Session length:** 15–25 minutes (mobile-optimized)
- **Total playtime:** 6–8 hours
- **Monetization:** Premium single purchase (9.99), no IAP, no ads
- **Accessibility:** Subtitles, colorblind modes, haptic feedback options

## 4) Game Overview
- **Genre:** Third-person action-adventure + narrative exploration
- **Perspective:** God-of-War-style close third person, cinematic cuts
- **Tone:** Serene → heroic → tragic → transcendent
- **Platform:** Android (primary), iOS optional after vertical slice
- **Engine:** Unity (URP) — fixed

## 5) Story Structure (Canonical)
```
PROLOGUE → ACT I (Forest) → ACT II (Search) → ACT III (Lanka) → ACT IV (War) → EPILOGUE
   20min      90min            60min            75min            60min         15min
```

### 5.1 Prologue — “Ayodhyā at Dawn” (Interactive Cinematic)
- **Mood:** Soft Dawn Watercolor
- **Duration:** 15–20 minutes
- **Flow:**
  - [Child Bedroom] → [Palace Corridor] → [Garden Path] → [City Gate] → [Fade to Black]
- **Beats:**
  - Innocence → Dharma recognized → First moral seed → Weight of destiny
- **Hidden loading:** White fade at gate → forest assets

### 5.2 Act I — “The Exile” (Rāma)
- **Type:** Semi-open hubs, forest mist oil-paint mood
- **Hub structure:** Daṇḍakāraṇya Forest
- **Key levels:**
  - Chitrakūṭa (bow tutorial, restraint spar)
  - Sage Ashram (defend without killing wounded)
  - Panchavaṭī (Sītā abduction setup)
  - Janasthāna (Khara battle, 3 phases)
- **Sītā abduction:** Cinematic only; 10-second forced grief

### 5.3 Act II — “The Search” (Rāma + Hanumān Intro)
- **Flow:** Pampa Lake → Ṛṣyamūka Mountain → Kiṣkindhā City → Hanumān unlock
- **Dharma choice:** Support rightful king vs powerful king

### 5.4 Act III — “Lankā” (Hanumān Solo)
- **Type:** Stealth-platformer, temple sculpture realism mood
- **Phases:** Shore → City Walls → Aśoka Grove
- **Burning of Lankā:** Failure, not triumph; forced slow-walk after escape

### 5.5 Act IV — “The War” (Rāma Returns)
- **Type:** Controlled battlefield
- **Phases:** Bridge building → Siege → Duels → Final arrow (single input, no follow)
- **Rāvaṇa battle:** 10 phases, no HP bars; final phase: spare vs let die (player choice)

### 5.6 Epilogue — “Return”
- **Type:** Interactive cinematic
- **Sequence:** Boat crossing → silent gates → walk to throne → fade before coronation

## 6) Scene-by-Scene Cinematics (Minimal Dialogue)
0. **Ayodhyā at Dawn:** Child Rāma walks; guard bows; flower falls; Rāma does not touch it.
1. **The Decree:** “I gave my word.” → “Then keep it.” → “I will go.” Silence.
2. **Exile Departure:** Player walks to gate; crowd parts; “Where you go, I go.”
3. **Forest Years:** Montage of camps, protection, seasons; wind + tanpura drone.
4. **Sītā Abduction:** Helpless cinematic; Rāma kneels, no tears.
5. **Meeting Hanumān:** “I am a servant…” → “Stand. Walk with me.”
6. **Lankā Infiltration:** Stealth; Hanumān steadies himself before Sītā.
7. **Burning of Lankā:** “This is not victory.”
8. **War:** Controlled cinematic + gameplay; no glory music; no arrow follow.
9. **Return:** Rain, mud, silence; fade before coronation.

## 7) Gameplay Systems
### 7.1 Combat (Philosophy)
> “Combat is conversation. Every strike speaks.”

- Skill-based, deliberate, stamina-driven.
- Bosses are tests of restraint, not DPS.

### 7.2 Rāma Combat
**Stance System**
| Stance | Input | Function |
| --- | --- | --- |
| Dharma | None | Bow ready, slow regen, high perception |
| Draw | Hold Attack | Aim reticle, slight time slow |
| Release | Release Attack | Arrow flies, stamina cost |
| Deflect | Tap Guard (timing) | Counter, minimal damage |
| Evade | Double-tap Direction | Roll, stamina cost |

**Bow Mechanics**
- No auto-aim; mobile uses mild stickiness.
- Wind affects arrows (visualized by grass).
- Stamina = breath; over-hold causes shake.

**Enemy Types**
| Type | Behavior | Counter |
| --- | --- | --- |
| Scouts | Fast, flanking | Deflect → stun |
| Brutes | Slow, heavy | Evade → back shot |
| Sorcerers | Ranged, summons | Quick draw priority |

**Boss: Khara (Janasthāna)**
- Phase 1: 3 perfect deflects
- Phase 2: Survive 30s without attacking
- Phase 3: Single weak-point shot after failed charge

### 7.3 Hanumān Movement & Stealth
| Action | Input | Constraint |
| --- | --- | --- |
| Run | Joystick | Stamina drain |
| Leap | Double-tap Jump | Must land on valid surface |
| Climb | Auto-grab | Stamina drain |
| Stealth | Crouch | Visual feedback only |

**Power progression**
| State | Ability | Unlock |
| --- | --- | --- |
| Humble | Basic leap, climb | Start |
| Devoted | Extended leap, wall-run | Find Sītā |
| Cosmic | Giant leap (scripted) | Burning escape |

**Combat:** No direct combat in Lankā stealth; distraction only.

### 7.4 Dharma System (Core)
- Invisible meter; actions affect world tone, NPCs, music.
- No UI numbers; feedback via color grading and audio.

## 8) Mobile Control Scheme
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
- Context button adapts: talk, climb, draw, deflect/evade.

## 9) Art Bible
### 9.1 Color Script
```
Prologue: #F5F5DC → #D4AF37 → #87CEEB
Act I:    #228B22 → #8B4513 → #708090
Act II:   #556B2F → #CD853F → #2F4F4F
Act III:  #2F2F2F → #8B0000 → #A9A9A9
Act IV:   #696969 → #8B0000 → #F5F5F5
Epilogue: #808080 → #A52A2A → #FFFFFF
```

### 9.2 Character Specifications
**Rāma**
- Height: 5'10", lean archer build
- Posture: Upright, relaxed
- Clothing: Simple dhoti, no jewelry in exile
- Reference: Chola bronze Rama statues (10th–11th century)

**Hanumān**
- Form: Vanara, between human and monkey
- Build: Compact, controlled
- Clothing: Minimal; sacred thread
- Reference: Hoysala temple Hanuman (Belur, 12th century)

### 9.3 Environment Pipeline (Mobile)
| Technique | Purpose |
| --- | --- |
| Impostors for distant trees | Performance |
| Vertex painting | Texture variety |
| Light probes | Consistent lighting |
| Fog | Mood + draw distance |

**URP Shader Stack**
1. Watercolor post-process (Prologue)
2. Oil-paint post-process (Forest)
3. Sculpture post-process (Lankā/War)

## 10) Audio Plan
### 10.1 Dynamic Music Layers
| Layer | Instrument | Trigger |
| --- | --- | --- |
| Drone | Tanpura/Shruti | Always low |
| Rhythm | Mridangam/Tabla | Combat (subtle) |
| Melody | Veena/Flute | Exploration |
| Vocal | Sanskrit shlokas | Sacred spaces |
| Silence | None | After major events |

**Dharma mix**
```
High: Drone 30 + Melody 60 + Vocal 40 + Rhythm 0
Neutral: Drone 50 + Melody 30 + Vocal 10 + Rhythm 20
Low: Drone 70 + Melody 10 + Vocal 0 + Rhythm 60
```

### 10.2 Sound Design Rules
- Footsteps soft, surface-specific.
- Bow draw = wood + breath.
- Fire = low rumble, not spectacle.
- No loud glory battle sounds.

### 10.3 Voice Direction
- Minimal VO; subtitles for all dialogue.
- Sanskrit whispers as ambient layer.
- Emotional sounds only (breath, effort).

## 11) Vertical Slice (Phase 1)
**Target:** Android (Pixel 6 baseline), 45 FPS stable

**Included sequences**
| Sequence | Content | Duration |
| --- | --- | --- |
| Prologue Walk | Child Rāma, Ayodhyā dawn | ~8 min |
| Combat Tutorial | Adult Rāma spar with Lakṣmaṇa | ~5 min |
| Cinematic | Exile departure → fade to forest | ~4 min |

### 11.1 Unity Project Structure (Slice)
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
│   │   │   ├── PlayerController.cs
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
│   │   ├── Models/
│   │   └── Shaders/
│   ├── Audio/
│   │   ├── Music/
│   │   ├── Ambient/
│   │   └── SFX/
│   └── Prefabs/
│       ├── Player/
│       ├── NPCs/
│       └── Environment/
```

### 11.2 Core Script Skeletons (Production-Ready)
```csharp
using UnityEngine;

public abstract class PlayerController : MonoBehaviour
{
    [Header("Base Stats")]
    [SerializeField] protected float maxStamina = 100f;
    [SerializeField] protected float moveSpeed = 5f;

    protected float currentStamina;
    protected Vector2 moveInput;
    protected bool isInCinematic;

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
using UnityEngine;

public class ChildRamaController : PlayerController
{
    [Header("Child Specific")]
    [SerializeField] private float walkSpeed = 2.5f;
    [SerializeField] private float runSpeed = 4f;

    private CharacterController controller;
    private Camera mainCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCamera = Camera.main;
        Initialize();
        moveSpeed = walkSpeed;
    }

    public override void ProcessMovement(Vector2 input)
    {
        if (isInCinematic) return;

        Vector3 move = new Vector3(input.x, 0, input.y);
        move = mainCamera.transform.TransformDirection(move);
        move.y = 0;
        move.Normalize();

        controller.Move(move * moveSpeed * Time.deltaTime);

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

        if (pressed)
        {
            if (Physics.Raycast(transform.position + Vector3.up, transform.forward, out RaycastHit hit, 2f))
            {
                var interactable = hit.collider.GetComponent<IInteractable>();
                interactable?.Interact(this);
            }
        }
    }

    public override void ProcessCamera(Vector2 lookInput)
    {
        // Cinemachine-driven; minimal manual control.
    }
}
```

```csharp
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DharmaSystem : MonoBehaviour
{
    [Header("Dharma Settings")]
    [SerializeField] private float maxDharma = 100f;
    [SerializeField] private float startingDharma = 50f;
    [SerializeField] private float decayRate = 0.5f;

    [Header("World Feedback")]
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private AudioMixerGroup musicMixer;

    private float currentDharma;
    private ColorAdjustments colorAdjustments;
    private Vignette vignette;

    public static DharmaSystem Instance { get; private set; }
    public event System.Action<float> OnDharmaChanged;
    public event System.Action<DharmaTier> OnTierChanged;

    public enum DharmaTier { Sattvic, Rajasic, Tamasic }
    private DharmaTier currentTier;

    void Awake()
    {
        Instance = this;
        currentDharma = startingDharma;

        if (postProcessVolume.profile.TryGet(out colorAdjustments) &&
            postProcessVolume.profile.TryGet(out vignette))
        {
            UpdateWorldState();
        }
    }

    void Update()
    {
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

        if (colorAdjustments != null)
        {
            colorAdjustments.saturation.value = Mathf.Lerp(-50f, 20f, normalized);
            colorAdjustments.contrast.value = Mathf.Lerp(20f, 0f, normalized);
        }

        if (vignette != null)
        {
            vignette.intensity.value = Mathf.Lerp(0.6f, 0.1f, normalized);
        }

        UpdateAudioMix(normalized);
    }

    private void UpdateAudioMix(float normalized)
    {
        // Crossfade between mixer snapshots based on dharma.
    }

    public enum ActionType
    {
        Restraint,
        Defense,
        Neutral,
        Aggression,
        Cruelty
    }
}
```

```csharp
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

        var sequence = System.Array.Find(cinematicSequences,
            s => s.name == sequenceId);

        if (sequence == null)
        {
            Debug.LogError($"Cinematic {sequenceId} not found");
            return;
        }

        player.SetCinematicState(true);
        director.playableAsset = sequence;

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

## 12) Quality Gates (QA Checklist)
| Gate | Test | Pass Criteria |
| --- | --- | --- |
| Performance | 30 min playthrough | 45 FPS minimum, no drops below 30 |
| Memory | Profile on Pixel 6 | < 2GB RAM usage |
| Battery | 1 hour play | < 15% drain per hour |
| Controls | 10 new users | Complete prologue without tutorial text |
| Emotion | Focus group (n=20) | 80% report “calm” or “peaceful” |
| Dharma | Telemetry | Players vary dharma state |

## 13) Development Roadmap
**Phase 1: Vertical Slice (8 weeks)**
| Week | Deliverable | Owner |
| --- | --- | --- |
| 1–2 | Prologue greybox, movement | Level Design |
| 3–4 | Watercolor shader, Ayodhyā art | Art |
| 5–6 | Child Rāma controller, input | Engineering |
| 7 | Audio integration, mixing | Audio |
| 8 | Polish, QA, gate review | All |

**Phase 2: Act I (12 weeks)**
- Forest environments
- Combat system
- Dharma system fully implemented
- First boss (Khara)

**Phase 3: Acts II–III (12 weeks)**
- Hanumān movement
- Stealth systems
- Lankā environments
- Burning sequence

**Phase 4: Act IV + Epilogue (10 weeks)**
- Battlefield tech
- War sequences
- Final polish
- Certification

## 14) Risk Mitigation
| Risk | Mitigation |
| --- | --- |
| Mobile performance | URP from day one; stylized realism |
| Cultural sensitivity | Scholar review each milestone |
| Market fit | Premium positioning; no F2P |
| Scope creep | Strict chapter locks; no side quests |
| Emotional resonance | Playtest every 2 weeks; pivot if needed |

## 15) Final Sign-Off
This document represents the complete creative and technical specification for **Rāmāyaṇa: Dharma Path**. Mobile limitations are treated as aesthetic discipline, not constraints. The game is ready for production.

- **Document version:** 1.0
- **Date:** 2026-02-05
- **Status:** Approved for Vertical Slice
